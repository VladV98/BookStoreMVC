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
                new Book {BookId = 1, Name="The C# Programming Yellow Book", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Learn C# from first principles the Rob Miles way.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7287/9781728724966.jpg", InStock=true, IsBookOfTheWeek=false, ImageThumbnailUrl="https://ibb.co/6RKrYym"},
                new Book {BookId = 2, Name="Java Programming Vol I", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="My 25 years plus of applicable experience of application/software development within the government, encompassed with more than 20 years of professional instruction of complex programming languages at the collegiate level led me to create this in-depth 1000 page book with detailed code examples.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7100/9781710000740.jpg", InStock=true, IsBookOfTheWeek=false, ImageThumbnailUrl="https://ibb.co/RjMvLdf"},
                new Book {BookId = 3, Name="Python For Kids", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Python is a powerful, expressive programming language that's easy to learn and fun to use! But books about learning to program in Python can be kind of dull, gray, and boring, and that's no fun for anyone.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593274078.jpg", InStock=true, IsBookOfTheWeek=true, ImageThumbnailUrl="https://ibb.co/HVZRHzq"},
                new Book {BookId = 4, Name="An Introduction to Functional Programming Through Lambda Calculus", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Functional programming is rooted in lambda calculus, which constitutes the world's smallest programming language. This well-respected text offers an accessible introduction to functional programming concepts and techniques for students of mathematics and computer science. The treatment is as nontechnical as possible, and it assumes no prior knowledge of mathematics or functional programming. Cogent examples illuminate the central ideas, and numerous exercises appear throughout the text, offering reinforcement of key concepts. All problems feature complete solutions.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/4864/9780486478838.jpg", InStock=true, IsBookOfTheWeek=true, ImageThumbnailUrl="https://ibb.co/jLMZK8C"}
            };

        public IEnumerable<Book> BooksOfTheWeek { get; }

        public Book GetBookById(int bookId)
        {
            return AllBooks.FirstOrDefault(p => p.BookId == bookId);
        }
    }
}
