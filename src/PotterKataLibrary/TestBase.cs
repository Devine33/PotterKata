using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterKataLibrary
{
    public class TestBase
    {
        public Basket BasketFullOfBooks_NoDiscount()
        {
            var basket = new Basket();
            basket.AddBook(BooksWithNoDiscount());
            return basket;
        }


        private List<Book> BooksWithNoDiscount()
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

        private List<Book> BooksWithFiveDiscount()
        {
            {
                return new List<Book>()
                {
                    new Book() {Name = "Phil. Stone"},
                    new Book() {Name = "Goblet"},
                };
            }
        }
    }
}