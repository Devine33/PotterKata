using NUnit.Framework;
using PotterKataLibrary;

namespace PotterKataLibraryTests
{
    public class PotterKataLibraryTests
    {
        private Basket _basket;
        private Checkout _checkout;

        [SetUp]
        public void Setup()
        {
            _basket = new Basket();
        }

        [Test]
        public void AddBook_UpdateBasketTotal()
        {
            var bookToAdd = new Book {Name = "Phil .Stone"};

            _basket.AddBook(bookToAdd);
            Assert.AreEqual(1, _basket.TotalNumberOfItems);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesNoDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOfBooks_NoDiscount());
            var total = _checkout.CalculateStandardTotal();
            Assert.AreEqual(40m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_FivePercentDiscount());
            var total = _checkout.CalculateStandardTotal();
            Assert.AreEqual(15.2m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTenPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_TenPercentDiscount());
            var discount = _checkout.CalculateStandardTotal();
            Assert.AreEqual(21.6m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesFifteenPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_FifteenPercentDiscount());
            var total = _checkout.CalculateStandardTotal();
            Assert.AreEqual(27.2, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTwentyFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_TwentyFivePercentDiscount());
            var total = _checkout.CalculateStandardTotal();
            Assert.AreEqual(30.0m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesThirtyPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_ThirtyPercentDiscount());
            var discount = _checkout.CalculateStandardTotal();
            Assert.AreEqual(33.6m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesThirtyFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_ThirtyFivePercentDiscount());
            var discount = _checkout.CalculateStandardTotal();
            Assert.AreEqual(36.4m, discount);
        }


        //TOTAL COST TESTS

        [Test]
        public void Checkout_CorrectlyCalculatesTotalCostWithNoDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOfBooks_NoDiscount());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(40m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTotalCostWithFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_FivePercentDiscount());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(15.2m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTotalCostWithTenPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_TenPercentDiscount());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(21.6m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTotalCostWithFifteenPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_FifteenPercentDiscount());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(27.2m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTotalCostWithTwentyFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_TwentyFivePercentDiscount());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(30.0m, total);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTotalCostWithThirtyPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_ThirtyPercentDiscount());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(33.6m, total);
        }

       [Test]
        public void Checkout_TestScenario()
        {
            _checkout = new Checkout(TestHelper.BasketFullOfBooks_TestScenario());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(60.80m, total);
        }
    }
}