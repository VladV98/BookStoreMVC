using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Computer books", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Science books", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Technical books", null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBookOfTheWeek", "LongDescription", "Name", "Paid", "Price", "ReleaseYear", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://i.ibb.co/Kjtb65X/Webp-net-resizeimage-3.png", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/7287/9781728724966.jpg", true, true, "Learn C# from first principles the Rob Miles way. With jokes, puns, and a rigorous problem solving based approach.You can download all the code samples used in the book from here: http: //www.robmiles.com/s/Yellow-Book-Code-Samples-64.z ", " C# Yellow Book", false, 14.12m, "19 Oct 2018", "Learn C# from first principles the Rob Miles way." },
                    { 3, 1, "https://i.ibb.co/MsdKCV7/Webp-net-resizeimage-1.png", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593274078.jpg", true, false, "Python is a powerful, expressive programming language that's easy to learn and fun to use! But books about learning to program in Python can be kind of dull, gray, and boring, and that's no fun for anyone. Python for Kids brings Python to life and brings you (and your parents) into the world of programming. The ever-patient Jason R. Briggs will guide you through the basics as you experiment with unique (and often hilarious) example programs that feature ravenous monsters, secret agents, thieving ravens, and more. ", "Python For Kids", false, 22.74m, "17 Jan 2013", "Python is a powerful, expressive programming language that's easy to learn and fun to use!" },
                    { 5, 1, "https://i.ibb.co/sQxFrwq/9781454926214.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4549/9781454926214.jpg", true, false, "With 250 illustrated landmark inventions, publications, and events--encompassing everything from ancient record-keeping devices to the latest computing technologies--this highly topical addition to the Sterling Milestones series takes a chronological journey through the history and future of computer science. Two expert authors, with decades' of experience working in computer research and innovation, explore topics including the Sumerian abacus, the first spam message, Morse code, cryptography, early computers, Isaac Asimov's laws of robotics, UNIX and early programming languages, movies, video games, mainframes, minis and micros, hacking, virtual reality, and more.", "The Computer Book : From the Abacus to Artificial Intelligence", false, 13.95m, "06 Nov 2018", "Part of Sterling's extremely popular Milestones series, this illustrated exploration of computer science ranges from the ancient abacus to superintelligence and social media." },
                    { 7, 1, "https://i.ibb.co/TwCbZwF/9781593271053.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5932/9781593271053.jpg", false, false, "As seasoned author Wallace Wang explains, hacking can also mean questioning the status quo, looking for your own truths and never accepting at face value anything authorities say or do. The completely revised fourth edition of this offbeat, non-technical book examines what hackers do, how they do it, and how you can protect yourself. Written in the same informative, irreverent, and entertaining style that made the first three editions hugely successful, Steal This Computer Book 4.0 will expand your mind and raise your eyebrows. New chapters discuss the hacker mentality, social engineering and lock picking, exploiting P2P file-sharing networks, and how people manipulate search engines and pop-up ads to obtain and use personal information. Wang also takes issue with the media for hacking the news and presenting the public with self-serving stories of questionable accuracy. ", "Steal This Computer Book 4.0", false, 21.44m, "05 Jun 2006", "If you thought hacking was just about mischief-makers hunched over computers in the basement, think again" },
                    { 9, 1, "https://i.ibb.co/HDFRggX/9780748782987.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/7487/9780748782987.jpg", true, true, "Learning Objectives, clearly referenced to the related statements in the AQA specification, let students know exactly what they'll need to learn and understand in that topic. Learning Activities in the student's books are enhanced by electronic animations, simulations and videos. Study tips provide essential advice on common errors and exam preparation. Summary questions promote independent learning and develop students' exam techniques through practice, preparation and study tips.", "AQA Computing A2: Student Book", false, 32.95m, "01 Nov 2014", "AQA Computing offers complete coverage and support through a variety of truly blended printed and online resources." },
                    { 2, 2, "https://i.ibb.co/WKQhH0y/Webp-net-resizeimage-4.png", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4919/9781491910399.jpg", true, false, "Learn how to use R to turn raw data into insight, knowledge, and understanding. This book introduces you to R, RStudio, and the tidyverse, a collection of R packages designed to work together to make data science fast, fluent, and fun. Suitable for readers with no previous programming experience, R for Data Science is designed to get you doing data science as quickly as possible.", "R for Data Science", false, 30.69m, "20 Jan 2017", "Learn how to use R to turn raw data into insight, knowledge, and understanding." },
                    { 6, 2, "https://i.ibb.co/2th91z6/9780007284870.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/0072/9780007284870.jpg", true, false, "Since 2003 Dr Ben Goldacre has been exposing dodgy medical data in his popular Guardian column. In this eye-opening book he takes on the MMR hoax and misleading cosmetics ads, acupuncture and homeopathy, vitamins and mankind's vexed relationship with all manner of `toxins'. Along the way, the self-confessed `Johnny Ball cum Witchfinder General' performs a successful detox on a Barbie doll, sees his dead cat become a certified nutritionist and probes the supposed medical qualifications of `Dr' Gillian McKeith.", "Bad Science", false, 11.14m, "30 Mar 2010", "Ben Goldacre's wise and witty bestseller, shortlisted for the Samuel Johnson Prize, lifts the lid on quack doctors, flaky statistics, scaremongering journalists and evil pharmaceutical corporations." },
                    { 8, 2, "https://i.ibb.co/3sZ2sSF/9781409350156.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4093/9781409350156.jpg", true, true, "Exploring more than 80 of the world's most scientific theories and big ideas across the fields of physics, chemistry, biology, astronomy, geology, and maths, this book offers a fascinating look at the history of science.Discover how Galileo worked out his scientific theories of motion and inertia, why Isaac Newton gets the credit for them, and what the discovery of DNA meant.All the big scientific ideas are brought to life with quirky graphics, pithy quotes and step-by-step mind maps - from evolution and continental drift to black holes and genetic engineering - using eye-catching artworks to show how the ideas of famous scientists have affected our understanding of the world. ", "The Science Book : Big Ideas Simply Explained", false, 18.58m, "17 Sep 2015", "Exploring more than 80 of the world's most scientific theories and big ideas." },
                    { 4, 3, "https://i.ibb.co/0fMVNn0/Webp-net-resizeimage.png", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/4864/9780486478838.jpg", true, false, "Functional programming is rooted in lambda calculus, which constitutes the world's smallest programming language. This well-respected text offers an accessible introduction to functional programming concepts and techniques for students of mathematics and computer science. The treatment is as nontechnical as possible, and it assumes no prior knowledge of mathematics or functional programming. Cogent examples illuminate the central ideas, and numerous exercises appear throughout the text, offering reinforcement of key concepts. All problems feature complete solutions.", "An Introduction to Functional Programming Through Lambda Calculus", false, 20.97m, "18 Aug 2011", "Functional programming is rooted in lambda calculus, which constitutes the world's smallest programming language. " },
                    { 10, 3, "https://i.ibb.co/qntD57Y/9781118779613.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/1187/9781118779613.jpg", true, false, "Technical Analysis For Dummies helps you take a hard-headed look at what securities prices are actually doing rather than what economists or analysts say they should be doing, giving you the know-how to use that data to decide whether to buy or sell individual securities. Since the publication of the first edition, readers have been faced with many changes, such as new interest rates, looming bank crises, and adjusting market climates. This new edition provides an updated look at unique formulas and key indicators, as well as refreshed and practical examples that reflect today today's financial atmosphere. * Determine how markets are performing and make decisions using real data * Spot investment trends and turning points * Improve your profits and your portfolio performance With straightforward coverage of concepts and execution, Technical Analysis For Dummies shows you how to make better trading decisions in no time.", "Technical Analysis For Dummies", false, 32.06m, "18 Mar 2014", "A simple, straightforward guide to the fundamentals of technical analysis Technical analysis is a collection of techniques designed to help you make trading decisions in securities markets." },
                    { 11, 3, "https://i.ibb.co/ZgTyN6L/9780994169310.jpg", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/9941/9780994169310.jpg", false, false, "It's suitable for a wide range of audiences: aspiring technical writers and students of technical writing, non-writers who find themselves assigned with the task of creating technical documentation, established writers who want to bring more structure to their work, and anyone managing a documentation project.", "Technical Writing Process ", false, 18.95m, "23 May 2015", "The Technical Writing Process is a simple, five-step process that can be used to create almost any piece of technical documentation such as a user guide, manual or procedure." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
