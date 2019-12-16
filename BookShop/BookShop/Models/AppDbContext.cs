using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Computer books" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Science books" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Technical books" });

            //seed pies

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Name = " C# Yellow Book",
                Price = 14.12M,
                ShortDescription = "Learn C# from first principles the Rob Miles way.",
                LongDescription = "Learn C# from first principles the Rob Miles way. With jokes, puns, and a rigorous problem solving based approach.You can download all the code samples used in the book from here: http: //www.robmiles.com/s/Yellow-Book-Code-Samples-64.z ",
                CategoryId = 1,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7287/9781728724966.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/Kjtb65X/Webp-net-resizeimage-3.png",
                ReleaseYear = "19 Oct 2018"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Name = "R for Data Science",
                Price = 30.69M,
                ShortDescription = "Learn how to use R to turn raw data into insight, knowledge, and understanding.",
                LongDescription = "Learn how to use R to turn raw data into insight, knowledge, and understanding. This book introduces you to R, RStudio, and the tidyverse, a collection of R packages designed to work together to make data science fast, fluent, and fun. Suitable for readers with no previous programming experience, R for Data Science is designed to get you doing data science as quickly as possible.",
                CategoryId = 2,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4919/9781491910399.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/WKQhH0y/Webp-net-resizeimage-4.png",
                ReleaseYear = "20 Jan 2017"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Name = "Python For Kids",
                Price = 22.74M,
                ShortDescription = "Easy Python book!",
                LongDescription = "Python is a powerful, expressive programming language that's easy to learn and fun to use! But books about learning to program in Python can be kind of dull, gray, and boring, and that's no fun for anyone. Python for Kids brings Python to life and brings you (and your parents) into the world of programming. The ever-patient Jason R. Briggs will guide you through the basics as you experiment with unique (and often hilarious) example programs that feature ravenous monsters, secret agents, thieving ravens, and more. ",
                CategoryId = 1,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593274078.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/MsdKCV7/Webp-net-resizeimage-1.png",
                ReleaseYear = "17 Jan 2013"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Name = "Functional Programming",
                Price = 20.97M,
                ShortDescription = "World's smallest programming language.",
                LongDescription = "Functional programming is rooted in lambda calculus, which constitutes the world's smallest programming language. This well-respected text offers an accessible introduction to functional programming concepts and techniques for students of mathematics and computer science. The treatment is as nontechnical as possible, and it assumes no prior knowledge of mathematics or functional programming. Cogent examples illuminate the central ideas, and numerous exercises appear throughout the text, offering reinforcement of key concepts. All problems feature complete solutions.",
                CategoryId = 3,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/4864/9780486478838.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/0fMVNn0/Webp-net-resizeimage.png",
                ReleaseYear = "18 Aug 2011"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Name = "The Computer Book",
                Price = 13.95M,
                ShortDescription = "Part of Sterling's extremely popular Milestones series",
                LongDescription = "With 250 illustrated landmark inventions, publications, and events--encompassing everything from ancient record-keeping devices to the latest computing technologies--this highly topical addition to the Sterling Milestones series takes a chronological journey through the history and future of computer science. Two expert authors, with decades' of experience working in computer research and innovation, explore topics including the Sumerian abacus, the first spam message, Morse code, cryptography, early computers, Isaac Asimov's laws of robotics, UNIX and early programming languages, movies, video games, mainframes, minis and micros, hacking, virtual reality, and more.",
                CategoryId = 1,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4549/9781454926214.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/sQxFrwq/9781454926214.jpg",
                ReleaseYear = "06 Nov 2018"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Name = "Bad Science",
                Price = 11.14M,
                ShortDescription = "This book will shock you!",
                LongDescription = "Since 2003 Dr Ben Goldacre has been exposing dodgy medical data in his popular Guardian column. In this eye-opening book he takes on the MMR hoax and misleading cosmetics ads, acupuncture and homeopathy, vitamins and mankind's vexed relationship with all manner of `toxins'. Along the way, the self-confessed `Johnny Ball cum Witchfinder General' performs a successful detox on a Barbie doll, sees his dead cat become a certified nutritionist and probes the supposed medical qualifications of `Dr' Gillian McKeith.",
                CategoryId = 2,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/0072/9780007284870.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/ByHZvKm/9780007284870-1.jpg",
                ReleaseYear = "30 Mar 2010"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                Name = "Steal This Book 5.0",
                Price = 21.44M,
                ShortDescription = "Hacking like never before!",
                LongDescription = "As seasoned author Wallace Wang explains, hacking can also mean questioning the status quo, looking for your own truths and never accepting at face value anything authorities say or do. The completely revised fourth edition of this offbeat, non-technical book examines what hackers do, how they do it, and how you can protect yourself. Written in the same informative, irreverent, and entertaining style that made the first three editions hugely successful, Steal This Computer Book 4.0 will expand your mind and raise your eyebrows. New chapters discuss the hacker mentality, social engineering and lock picking, exploiting P2P file-sharing networks, and how people manipulate search engines and pop-up ads to obtain and use personal information. Wang also takes issue with the media for hacking the news and presenting the public with self-serving stories of questionable accuracy. ",
                CategoryId = 1,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593271053.jpg",
                InStock = false,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/TwCbZwF/9781593271053.jpg",
                ReleaseYear = "05 Jun 2006"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 8,
                Name = "The Science Book",
                Price = 18.58M,
                ShortDescription = "Most scientific theories and big ideas.",
                LongDescription = "Exploring more than 80 of the world's most scientific theories and big ideas across the fields of physics, chemistry, biology, astronomy, geology, and maths, this book offers a fascinating look at the history of science.Discover how Galileo worked out his scientific theories of motion and inertia, why Isaac Newton gets the credit for them, and what the discovery of DNA meant.All the big scientific ideas are brought to life with quirky graphics, pithy quotes and step-by-step mind maps - from evolution and continental drift to black holes and genetic engineering - using eye-catching artworks to show how the ideas of famous scientists have affected our understanding of the world. ",
                CategoryId = 2,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4093/9781409350156.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/3sZ2sSF/9781409350156.jpg",
                ReleaseYear = "17 Sep 2015"
            });


            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 9,
                Name = "AQA Computing A2",
                Price = 32.95M,
                ShortDescription = "Coverage and support printed and online resources.",
                LongDescription = "Learning Objectives, clearly referenced to the related statements in the AQA specification, let students know exactly what they'll need to learn and understand in that topic. Learning Activities in the student's books are enhanced by electronic animations, simulations and videos. Study tips provide essential advice on common errors and exam preparation. Summary questions promote independent learning and develop students' exam techniques through practice, preparation and study tips.",
                CategoryId = 1,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/7487/9780748782987.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/HDFRggX/9780748782987.jpg",
                ReleaseYear = "01 Nov 2014"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 10,
                Name = "Technical Analysis For Dummies",
                Price = 32.06M,
                ShortDescription = "Fundamentals of technical analysis",
                LongDescription = "Technical Analysis For Dummies helps you take a hard-headed look at what securities prices are actually doing rather than what economists or analysts say they should be doing, giving you the know-how to use that data to decide whether to buy or sell individual securities. Since the publication of the first edition, readers have been faced with many changes, such as new interest rates, looming bank crises, and adjusting market climates. This new edition provides an updated look at unique formulas and key indicators, as well as refreshed and practical examples that reflect today today's financial atmosphere. * Determine how markets are performing and make decisions using real data * Spot investment trends and turning points * Improve your profits and your portfolio performance With straightforward coverage of concepts and execution, Technical Analysis For Dummies shows you how to make better trading decisions in no time.",
                CategoryId = 3,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/1187/9781118779613.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/qntD57Y/9781118779613.jpg",
                ReleaseYear = "18 Mar 2014"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 11,
                Name = "Technical Writing Process",
                Price = 18.95M,
                ShortDescription = "Simple five-step process!",
                LongDescription = "It's suitable for a wide range of audiences: aspiring technical writers and students of technical writing, non-writers who find themselves assigned with the task of creating technical documentation, established writers who want to bring more structure to their work, and anyone managing a documentation project.",
                CategoryId = 3,
                ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/9941/9780994169310.jpg",
                InStock = false,
                IsBookOfTheWeek = false,
                Paid = false,
                ImageThumbnailUrl = "https://i.ibb.co/ZgTyN6L/9780994169310.jpg",
                ReleaseYear = "23 May 2015"
            });
        }
    }
}
