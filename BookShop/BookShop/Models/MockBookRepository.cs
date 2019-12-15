using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class MockBookRepository: IBookRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Book> AllBooks =>
            new List<Book>
            {
                new Book {BookId = 1, Name="C# Yellow Book", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Learn C# from first principles the Rob Miles way.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7287/9781728724966.jpg", InStock=true, IsBookOfTheWeek=false, ImageThumbnailUrl="https://i.ibb.co/Kjtb65X/Webp-net-resizeimage-3.png"},
                new Book {BookId = 2, Name="R for Data Science", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Learn how to use R to turn raw data into insight, knowledge, and understanding. This book introduces you to R, RStudio, and the tidyverse, a collection of R packages designed to work together to make data science fast, fluent, and fun.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4919/9781491910399.jpg", InStock=true, IsBookOfTheWeek=false, ImageThumbnailUrl="https://i.ibb.co/WKQhH0y/Webp-net-resizeimage-4.png"},
                new Book {BookId = 3, Name="Python For Kids", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Python is a powerful, expressive programming language that's easy to learn and fun to use! But books about learning to program in Python can be kind of dull, gray, and boring, and that's no fun for anyone.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593274078.jpg", InStock=true, IsBookOfTheWeek=true, ImageThumbnailUrl="https://i.ibb.co/MsdKCV7/Webp-net-resizeimage-1.png"},
                new Book {BookId = 4, Name="An Introduction to Functional Programming Through Lambda Calculus", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Functional programming is rooted in lambda calculus, which constitutes the world's smallest programming language. This well-respected text offers an accessible introduction to functional programming concepts and techniques for students of mathematics and computer science. The treatment is as nontechnical as possible, and it assumes no prior knowledge of mathematics or functional programming. Cogent examples illuminate the central ideas, and numerous exercises appear throughout the text, offering reinforcement of key concepts. All problems feature complete solutions.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/4864/9780486478838.jpg", InStock=true, IsBookOfTheWeek=true, ImageThumbnailUrl="https://i.ibb.co/0fMVNn0/Webp-net-resizeimage.png"}
            };

        public IEnumerable<Book> BooksOfTheWeek { get; }

        public Book GetBookById(int bookId)
        {
            return AllBooks.FirstOrDefault(p => p.BookId == bookId);
        }
    }
}
