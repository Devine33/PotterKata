using NUnit.Framework;
using PotterKataLibrary;

namespace PotterKataLibraryTests
{
    public class Class1 
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
            var bookToAdd = new Book {Name = "Phil .Stone"};

            _basket.AddBook(bookToAdd);
            Assert.AreEqual(1,_basket.TotalNumberOfItems);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesNoDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOfBooks_NoDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_FivePercentDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0.05m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTenPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_TenPercentDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0.10m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesFifteenPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_FifteenPercentDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0.15m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesTwentyFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_TwentyFivePercentDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0.25m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesThirtyPercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_ThirtyPercentDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0.30m, discount);
        }

        [Test]
        public void Checkout_CorrectlyCalculatesThirtyFivePercentDiscount()
        {
            _checkout = new Checkout(TestHelper.BasketFullOFBooks_ThirtyFivePercentDiscount());
            var discount = _checkout.CalculateDiscount();
            Assert.AreEqual(0.35m, discount);
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
    }

    internal class Checkout
    {
        private readonly Basket _customerBasket;
        
        public Checkout(Basket basket)
        {
            _customerBasket = basket;
        }

    
        public decimal CompletePurchase()
        {
            var total = CalculateTotal();
            var discount = CalculateDiscount();

            var totalDiscount = total * discount;
            var finalPurchaseCost = total - totalDiscount;
            return finalPurchaseCost;

        }

        public decimal CalculateTotal()
        {
            var total = _customerBasket.TotalNumberOfItems * 8.00m;
            return total;
        }

        //Discount is based on total number of unique books purchased
        public decimal CalculateDiscount()
        {
            var uniqueBooks = _customerBasket.Books.Keys.Count;

            switch (uniqueBooks)
            {
                case 0:
                    return 0.0m;
                case 1:
                    return 0.0m;
                case 2:
                    return 0.05m;
                case 3:
                    return 0.10m;
                case 4:
                    return 0.15m;
                case 5:
                    return 0.25m;
                case 6:
                    return 0.30m;
                case 7:
                    return 0.35m;
            }

            return 0.0m;
        }
    }
}
