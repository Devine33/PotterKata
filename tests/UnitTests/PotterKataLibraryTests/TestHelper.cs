﻿using System.Collections.Generic;
using PotterKataLibrary;

namespace PotterKataLibraryTests
{
    public static class TestHelper
    {
        public static Basket BasketFullOfBooks_NoDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithNoDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_FivePercentDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithFiveDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_TenPercentDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithTenDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_FifteenPercentDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithFifteenDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_TwentyFivePercentDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithTwentyFiveDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_ThirtyPercentDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithThirtyDiscount());
            return basket;
        }

        public static Basket BasketFullOFBooks_ThirtyFivePercentDiscount()
        {
            var basket = new Basket();
            basket.AddBooks(BooksWithThirtyFiveDiscount());
            return basket;
        }

        public static Basket BasketFullOfBooks_TestScenario()
        {
            var basket = new Basket();
            basket.AddBooks(BooksTestScenario());
            return basket;
        }


        private static List<Book> BooksWithNoDiscount()
        {
            return new()
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
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                };
            }
        }

        private static List<Book> BooksWithTenDiscount()
        {
            {
                return new List<Book>()
                {
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                    new() {Name = "Azkhaban"},
                };
            }
        }

        private static List<Book> BooksWithFifteenDiscount()
        {
            {
                return new List<Book>()
                {
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                    new() {Name = "Azkhaban"},
                    new() {Name = "Chamber"},
                };
            }
        }

        private static List<Book> BooksWithTwentyFiveDiscount()
        {
            {
                return new List<Book>()
                {
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                    new() {Name = "Azkhaban"},
                    new() {Name = "Chamber"},
                    new() {Name = "Order"},
                };
            }
        }

        private static List<Book> BooksWithThirtyDiscount()
        {
            {
                return new List<Book>()
                {
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                    new() {Name = "Azkhaban"},
                    new() {Name = "Chamber"},
                    new() {Name = "Order"},
                    new() {Name = "Halfblood"},
                };
            }
        }

        private static List<Book> BooksWithThirtyFiveDiscount()
        {
            {
                return new List<Book>()
                {
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                    new() {Name = "Azkhaban"},
                    new() {Name = "Chamber"},
                    new() {Name = "Order"},
                    new() {Name = "Halfblood"},
                    new() {Name = "Deathly"},    
                };
            }
        }

        private static List<Book> BooksTestScenario()
        {
            {
                return new List<Book>()
                {
                    new() {Name = "Phil. Stone"},
                    new() {Name = "Goblet"},
                    new() {Name = "Goblet"},
                    new() {Name = "Azkhaban"},
                    new() {Name = "Azkhaban"},
                    new() {Name = "Chamber"},
                    new() {Name = "Chamber"},
                    new() {Name = "Order"},
                    new() {Name = "Order"},
                    new() {Name = "Halfblood"},
                };
            }
        }
    }
}