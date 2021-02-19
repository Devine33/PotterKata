using System.Collections.Generic;
using PotterKataLibrary;

namespace PotterKataLibraryTests
{
    public static class TestHelper
    {
        public static Basket BasketFullOfBooks_NoDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithNoDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_FivePercentDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithFiveDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_TenPercentDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithTenDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_FifteenPercentDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithFifteenDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_TwentyFivePercentDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithTwentyFiveDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_ThirtyPercentDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithThirtyDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_ThirtyFivePercentDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithThirtyFiveDiscount());
            return basket;
        }


        private static List<Book> BooksWithNoDiscount()
        {
            return new List<Book>()
            {
                new Book() {Name = "Phil. Stone"},
                new Book() {Name = "Phil. Stone"},
                new Book() {Name = "Phil. Stone"},
                new Book() {Name = "Phil. Stone"},
                new Book() {Name = "Phil. Stone"},
            };
        }

        private static List<Book> BooksWithFiveDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                };
            }
        }

        private static List<Book> BooksWithTenDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                    new Book() {Name = "Azkhaban"},
                };
            }
        }

        private static List<Book> BooksWithFifteenDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                    new Book() {Name = "Azkhaban"},
                    new Book() {Name = "Chamber"},
                };
            }
        }

        private static List<Book> BooksWithTwentyFiveDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                    new Book() {Name = "Azkhaban"},
                    new Book() {Name = "Chamber"},
                    new Book() {Name = "Order"},
                };
            }
        }

        private static List<Book> BooksWithThirtyDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                    new Book() {Name = "Azkhaban"},
                    new Book() {Name = "Chamber"},
                    new Book() {Name = "Order"},
                    new Book() {Name = "Halfblood"},
                };
            }
        }

        private static List<Book> BooksWithThirtyFiveDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                    new Book() {Name = "Azkhaban"},
                    new Book() {Name = "Chamber"},
                    new Book() {Name = "Order"},
                    new Book() {Name = "Halfblood"},
                    new Book() {Name = "Deathly"},    
                };
            }
        }

        private static List<Book> BooksTestScenario()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                    new Book() {Name = "Azkhaban"},
                    new Book() {Name = "Chamber"},
                    new Book() {Name = "Order"},
                    new Book() {Name = "Halfblood"},
                    new Book() {Name = "Deathly"},
                };
            }
        }
    }
}