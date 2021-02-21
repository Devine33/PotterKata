using System.Collections.Generic;

namespace PotterKataLibrary
{
    public class Basket
    {
        public List<Book> Books { get; } = new();
        public void AddBook(Book bookToAdd)
        {
           Books.Add(bookToAdd);
        }

        public void AddBooks(List<Book> booksToAdd)
        {
            foreach (var book in booksToAdd)
            {
                AddBook(book);
            }
        }

        public int TotalNumberOfItems => Books.Count;

    }
}