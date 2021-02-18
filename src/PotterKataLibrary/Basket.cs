using System.Collections.Generic;

namespace PotterKataLibrary
{
    public class Basket
    {
        private readonly List<Book> _books = new();

        public void AddBook(Book bookToAdd)
        {
            _books.Add(bookToAdd);
        }

        public void AddBook(List<Book> booksToAdd)
        {
            _books.AddRange(booksToAdd);
        }

        public int TotalNumberOfItems => _books.Count;
    }
}