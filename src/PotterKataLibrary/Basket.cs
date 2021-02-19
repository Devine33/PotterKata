using System.Collections.Generic;
using System.Linq;

namespace PotterKataLibrary
{
    public class Basket
    {
        public Dictionary<string,List<Book>> Books { get; } = new();
        public void AddBook(Book bookToAdd)
        {
            if (Books.ContainsKey(bookToAdd.Name))
            {
                Books[bookToAdd.Name].Add(bookToAdd);
            }
            else
            {
                Books.Add(bookToAdd.Name,new List<Book>(){bookToAdd});
            }
        }

        public void AddBook(List<Book> booksToAdd)
        {
            foreach (var book in booksToAdd)
            {
                AddBook(book);
            }
        }

        public int TotalNumberOfItems => Books.Sum(kvp => kvp.Value.Count);

    }
}