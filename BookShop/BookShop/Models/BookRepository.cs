using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _appDbConext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;

        }


        public IEnumerable<Book> AllBooks 
        { 
            get
            {
                return _appDbConext.Books.Include(c => c.Category);

            }
        }

        public IEnumerable<Book> BooksOfTheWeek 
        {
            get
            {
                return _appDbConext.Books.Include(c => c.Category).Where(p => p.IsBookOfTheWeek);// pies where piesoftheweek true

            }

        }

        public Book GetBookById(int bookId)
        {
            return _appDbConext.Books.FirstOrDefault(p => p.BookId == bookId);
        }
    }
}
