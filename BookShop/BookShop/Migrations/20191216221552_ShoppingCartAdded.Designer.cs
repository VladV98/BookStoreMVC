﻿// <auto-generated />
using System;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191216221552_ShoppingCartAdded")]
    partial class ShoppingCartAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBookOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Rob Miles",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.ibb.co/dPjGfXz/Webp-net-resizeimage-3.png",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7287/9781728724966.jpg",
                            InStock = true,
                            IsBookOfTheWeek = true,
                            LongDescription = "Learn C# from first principles the Rob Miles way. With jokes, puns, and a rigorous problem solving based approach.You can download all the code samples used in the book from here: http: //www.robmiles.com/s/Yellow-Book-Code-Samples-64.z ",
                            Name = " C# Yellow Book",
                            Paid = false,
                            Price = 14.12m,
                            ReleaseYear = "19 Oct 2018",
                            ShortDescription = "Learn C# from first principles the Rob Miles way."
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Garrett Grolemund",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://i.ibb.co/fkPtdL8/Webp-net-resizeimage-4.png",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4919/9781491910399.jpg",
                            InStock = true,
                            IsBookOfTheWeek = false,
                            LongDescription = "Learn how to use R to turn raw data into insight, knowledge, and understanding. This book introduces you to R, RStudio, and the tidyverse, a collection of R packages designed to work together to make data science fast, fluent, and fun. Suitable for readers with no previous programming experience, R for Data Science is designed to get you doing data science as quickly as possible.",
                            Name = "R for Data Science",
                            Paid = false,
                            Price = 30.69m,
                            ReleaseYear = "20 Jan 2017",
                            ShortDescription = "Learn how to use R to turn raw data into insight, knowledge, and understanding."
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Jason Briggs",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.ibb.co/k1vrFZN/Webp-net-resizeimage-1.png",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593274078.jpg",
                            InStock = true,
                            IsBookOfTheWeek = false,
                            LongDescription = "Python is a powerful, expressive programming language that's easy to learn and fun to use! But books about learning to program in Python can be kind of dull, gray, and boring, and that's no fun for anyone. Python for Kids brings Python to life and brings you (and your parents) into the world of programming. The ever-patient Jason R. Briggs will guide you through the basics as you experiment with unique (and often hilarious) example programs that feature ravenous monsters, secret agents, thieving ravens, and more. ",
                            Name = "Python For Kids",
                            Paid = false,
                            Price = 22.74m,
                            ReleaseYear = "17 Jan 2013",
                            ShortDescription = "Easy Python book!"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Greg Michaelson",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.ibb.co/FKsN8SN/Webp-net-resizeimage.png",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/4864/9780486478838.jpg",
                            InStock = true,
                            IsBookOfTheWeek = false,
                            LongDescription = "Functional programming is rooted in lambda calculus, which constitutes the world's smallest programming language. This well-respected text offers an accessible introduction to functional programming concepts and techniques for students of mathematics and computer science. The treatment is as nontechnical as possible, and it assumes no prior knowledge of mathematics or functional programming. Cogent examples illuminate the central ideas, and numerous exercises appear throughout the text, offering reinforcement of key concepts. All problems feature complete solutions.",
                            Name = "Functional Programming",
                            Paid = false,
                            Price = 20.97m,
                            ReleaseYear = "18 Aug 2011",
                            ShortDescription = "World's smallest programming language."
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Simson L. Garfinkel",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.ibb.co/hDBYgCY/9781454926214.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4549/9781454926214.jpg",
                            InStock = true,
                            IsBookOfTheWeek = false,
                            LongDescription = "With 250 illustrated landmark inventions, publications, and events--encompassing everything from ancient record-keeping devices to the latest computing technologies--this highly topical addition to the Sterling Milestones series takes a chronological journey through the history and future of computer science. Two expert authors, with decades' of experience working in computer research and innovation, explore topics including the Sumerian abacus, the first spam message, Morse code, cryptography, early computers, Isaac Asimov's laws of robotics, UNIX and early programming languages, movies, video games, mainframes, minis and micros, hacking, virtual reality, and more.",
                            Name = "The Computer Book",
                            Paid = false,
                            Price = 13.95m,
                            ReleaseYear = "06 Nov 2018",
                            ShortDescription = "Part of Sterling's extremely popular Milestones series"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Ben Goldacre",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://i.ibb.co/dcNJ1Kx/9780007284870.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/0072/9780007284870.jpg",
                            InStock = true,
                            IsBookOfTheWeek = false,
                            LongDescription = "Since 2003 Dr Ben Goldacre has been exposing dodgy medical data in his popular Guardian column. In this eye-opening book he takes on the MMR hoax and misleading cosmetics ads, acupuncture and homeopathy, vitamins and mankind's vexed relationship with all manner of `toxins'. Along the way, the self-confessed `Johnny Ball cum Witchfinder General' performs a successful detox on a Barbie doll, sees his dead cat become a certified nutritionist and probes the supposed medical qualifications of `Dr' Gillian McKeith.",
                            Name = "Bad Science",
                            Paid = false,
                            Price = 11.14m,
                            ReleaseYear = "30 Mar 2010",
                            ShortDescription = "This book will shock you!"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Wallace Wang",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.ibb.co/vjXQnYF/9781593271053.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593271053.jpg",
                            InStock = false,
                            IsBookOfTheWeek = false,
                            LongDescription = "As seasoned author Wallace Wang explains, hacking can also mean questioning the status quo, looking for your own truths and never accepting at face value anything authorities say or do. The completely revised fourth edition of this offbeat, non-technical book examines what hackers do, how they do it, and how you can protect yourself. Written in the same informative, irreverent, and entertaining style that made the first three editions hugely successful, Steal This Computer Book 4.0 will expand your mind and raise your eyebrows. New chapters discuss the hacker mentality, social engineering and lock picking, exploiting P2P file-sharing networks, and how people manipulate search engines and pop-up ads to obtain and use personal information. Wang also takes issue with the media for hacking the news and presenting the public with self-serving stories of questionable accuracy. ",
                            Name = "Steal This Book",
                            Paid = false,
                            Price = 21.44m,
                            ReleaseYear = "05 Jun 2006",
                            ShortDescription = "Hacking like never before!"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Dorling Kindersley",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://i.ibb.co/1vDYw6b/9781409350156.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4093/9781409350156.jpg",
                            InStock = true,
                            IsBookOfTheWeek = true,
                            LongDescription = "Exploring more than 80 of the world's most scientific theories and big ideas across the fields of physics, chemistry, biology, astronomy, geology, and maths, this book offers a fascinating look at the history of science.Discover how Galileo worked out his scientific theories of motion and inertia, why Isaac Newton gets the credit for them, and what the discovery of DNA meant.All the big scientific ideas are brought to life with quirky graphics, pithy quotes and step-by-step mind maps - from evolution and continental drift to black holes and genetic engineering - using eye-catching artworks to show how the ideas of famous scientists have affected our understanding of the world. ",
                            Name = "The Science Book",
                            Paid = false,
                            Price = 18.58m,
                            ReleaseYear = "17 Sep 2015",
                            ShortDescription = "Most scientific theories and big ideas."
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Sylvia Langfield",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.ibb.co/Hhc8DFm/9780748782987.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/7487/9780748782987.jpg",
                            InStock = true,
                            IsBookOfTheWeek = true,
                            LongDescription = "Learning Objectives, clearly referenced to the related statements in the AQA specification, let students know exactly what they'll need to learn and understand in that topic. Learning Activities in the student's books are enhanced by electronic animations, simulations and videos. Study tips provide essential advice on common errors and exam preparation. Summary questions promote independent learning and develop students' exam techniques through practice, preparation and study tips.",
                            Name = "AQA Computing A2",
                            Paid = false,
                            Price = 32.95m,
                            ReleaseYear = "01 Nov 2014",
                            ShortDescription = "Coverage and support printed and online resources."
                        },
                        new
                        {
                            BookId = 10,
                            Author = "Barbara Rockefeller",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.ibb.co/540LJMc/9781118779613.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/1187/9781118779613.jpg",
                            InStock = true,
                            IsBookOfTheWeek = false,
                            LongDescription = "Technical Analysis For Dummies helps you take a hard-headed look at what securities prices are actually doing rather than what economists or analysts say they should be doing, giving you the know-how to use that data to decide whether to buy or sell individual securities. Since the publication of the first edition, readers have been faced with many changes, such as new interest rates, looming bank crises, and adjusting market climates. This new edition provides an updated look at unique formulas and key indicators, as well as refreshed and practical examples that reflect today today's financial atmosphere. * Determine how markets are performing and make decisions using real data * Spot investment trends and turning points * Improve your profits and your portfolio performance With straightforward coverage of concepts and execution, Technical Analysis For Dummies shows you how to make better trading decisions in no time.",
                            Name = "Technical Analysis For Dummies",
                            Paid = false,
                            Price = 32.06m,
                            ReleaseYear = "18 Mar 2014",
                            ShortDescription = "Fundamentals of technical analysis"
                        },
                        new
                        {
                            BookId = 11,
                            Author = "Kieran Morgan",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.ibb.co/vqkbW7W/9780994169310.jpg",
                            ImageUrl = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/9941/9780994169310.jpg",
                            InStock = false,
                            IsBookOfTheWeek = false,
                            LongDescription = "It's suitable for a wide range of audiences: aspiring technical writers and students of technical writing, non-writers who find themselves assigned with the task of creating technical documentation, established writers who want to bring more structure to their work, and anyone managing a documentation project.",
                            Name = "Technical Writing Process",
                            Paid = false,
                            Price = 18.95m,
                            ReleaseYear = "23 May 2015",
                            ShortDescription = "Simple five-step process!"
                        });
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Computer books"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Science books"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Technical books"
                        });
                });

            modelBuilder.Entity("BookShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("BookId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.HasOne("BookShop.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
