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
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            BooksListViewModel booksListViewModel = new BooksListViewModel();
            booksListViewModel.Books = _bookRepository.AllBooks;
            booksListViewModel.CurrentCategory = "Computer Books";
            return View(booksListViewModel);// displays all books
        }
    }
}
