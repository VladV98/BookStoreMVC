using BookStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BookStoreMVC.DatabaseContext
{
    public class BookStoreDatabaseInitializer : DropCreateDatabaseIfModelChanges<BookStoreDbContext>
    {
        protected override void Seed(BookStoreDbContext context)
        {
            context.Books.AddOrUpdate(
                x => x.Name,
                new Book
                {
                    Name = "Dark Light",
                    Author = "Jodi Taylor",
                    Description = "The second novel in the gripping supernatural thriller series from international bestselling author Jodi Taylor. Betrayed, terrified and alone, Elizabeth Cage has fled her home. With no plan and no friends, she arrives at the picturesque village of Greyston and finds herself involved in an ages-old ceremony that will end in death.And that might be the least of her problems - the Sorensen Institute would very much like to know her whereabouts. And Michael Jones is still out there, somewhere, she hopes. No matter how far and how fast she can run, trouble will always find Elizabeth Cage.",
                    Year = "01.07.2019", //Year of publication
                    Price = 13.49
                },
                new Book
                {
                    Name = "test1",
                    Author = "gg",
                    Description = "hfgh",
                    Year = "01.07.2019", //Year of publication
                    Price = 10
                },
                new Book
                {
                    Name = "test2",
                    Author = "hh",
                    Description = "dx",
                    Year = "01.07.2019", //Year of publication
                    Price = 15
                },
                new Book
                {
                    Name = "test3",
                    Author = "tt",
                    Description = "dgzd",
                    Year = "01.07.2019", //Year of publication
                    Price = 16
                },
                new Book
                {
                    Name = "test4",
                    Author = "jj",
                    Description = "zdgzdg",
                    Year = "01.07.2019", //Year of publication
                    Price = 20
                }
                );
        }
    }
}