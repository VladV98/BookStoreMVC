 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBookRepository bookRepository, ShoppingCart shoppingCart)
        {
            _bookRepository = bookRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()// returns view for shopping cart
        {
            var items = _shoppingCart.GetShoppingCartItems(); // ask for shopping cart items
            _shoppingCart.ShoppingCartItems = items;  

            var shoppingCartViewModel = new ShoppingCartViewModel //pass to viewmodel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()//show shopping cart total
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int bookId)// passed id of the book that needs to be added
        {
            var selectedBook = _bookRepository.AllBooks.FirstOrDefault(p => p.BookId == bookId); //gets book through bookrepository

            if (selectedBook != null)//passes to shopping cart selected book to add to cart method
            {
                _shoppingCart.AddToCart(selectedBook, 1);//redirects user to index action on shoppingcart controller
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int bookId)
        {
            var selectedBook = _bookRepository.AllBooks.FirstOrDefault(p => p.BookId == bookId);

            if (selectedBook != null)
            {
                _shoppingCart.RemoveFromCart(selectedBook);
            }
            return RedirectToAction("Index");
        }
    }
}
