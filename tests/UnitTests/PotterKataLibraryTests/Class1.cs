using System.ComponentModel.Design;
using NUnit.Framework;
using PotterKataLibrary;

namespace PotterKataLibraryTests
{
    public class Class1 : TestBase
    {
        private  Basket _basket;
        private Checkout _checkout;
        [SetUp]
        public void Setup()
        {
            _basket = new Basket();
        }

        [Test]
        public void AddBook_UpdateBasketTotal()
        {
            var bookToAdd = new Book() {Name = "Phil .Stone"};
            _basket.AddBook(bookToAdd);
            Assert.AreEqual(1,_basket.TotalNumberOfItems);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesBooksNoDiscount()
        {
            var books = BasketFullOfBooks_NoDiscount();
            var total = _checkout.CalculateTotal();
            Assert.AreEqual(40,total);
        }
    }

    internal class Checkout
    {
        public decimal CalculateTotal()
        {
            throw new System.NotImplementedException();
        }
    }
}
