using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string ShoppingCartId { get; set; }
        public Boolean Paid { get; set; }
        public DateTime ShoppingCartDateCreated { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?//IHttpContextAccessor brings support for sessions
                .HttpContext.Session; //.HttpContext.Session access gives all information about request; allows to store sessions on server side between cookies and underlying mechanims asp net cookies

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();//check the session to see if the string already has ID CartId, if not creates new Guid

            
            
            session.SetString("CartId", cartId);// cartId set for the session 

            return new ShoppingCart(context)
            {

                ShoppingCartId = cartId,//creates new shopping cart passing appdbcontext with shoppingcartid set as cartid
                ShoppingCartDateCreated = DateTime.Now, // Date created
                Paid = false
            };
        }

        public void AddToCart(Book book, int amount)// add to cart method
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == book.BookId && s.ShoppingCartId == ShoppingCartId);// check if bookid is found in shoppingcart

            if (shoppingCartItem == null)//book not in shopping cart yet
            {
                shoppingCartItem = new ShoppingCartItem //creates new shopping cart item
                {
                    ShoppingCartId = ShoppingCartId,
                    Book = book,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);//add shoppingcart item to the list managed by appdbcontext in its dbset
            }
            else
            {
                shoppingCartItem.Amount++;//if found increase amount
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Book book)// remove from cart method if found
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == book.BookId && s.ShoppingCartId == ShoppingCartId);// 

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()//will look if shopping cart items were already previously retrieved in this current shopping cart instance
        {
            return ShoppingCartItems ?? //if list null going to go to appdbcontext and retrieve shoppingcart items where shopping cart is the given shopping cart id currently associated with session of the user 
                   (ShoppingCartItems =
                       _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Book)
                           .ToList());
        }

        public void ClearCart()// clears shopping cart items thats associated with shopping cart id
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()// uses LINQ query to calculate sum for all the items in shopping cart
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Book.Price * c.Amount).Sum();
            return total;
        }
    }
}
