using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PotterKataLibrary;

namespace PotterKataLibraryTests
{
    public class Class1
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

       [Test]
        public void Checkout_TestScenario()
        {
            _checkout = new Checkout(TestHelper.BasketFullOfBooks_TestScenario());
            var total = _checkout.CompletePurchase();
            Assert.AreEqual(60.80m, total);
        }
    }

    internal class Checkout
    {
        private readonly Basket _customerBasket;
        private List<List<string>> _discountGroups = new List<List<string>>();

        public Checkout(Basket basket)
        {
            _customerBasket = basket;
        }


        public decimal CompletePurchase()
        {
            var finalDiscount = 0.0m;

            var total = CalculateTotal();
            var discount = CalculateDiscount();

            var groupDiscount = CalculateGroupTotal();

            finalDiscount = groupDiscount > finalDiscount ? groupDiscount : discount;

            var totalDiscount = total * finalDiscount;
            var finalPurchaseCost = total - totalDiscount;

            return groupDiscount > finalPurchaseCost ? groupDiscount : finalPurchaseCost;
        }

        public decimal CalculateTotal()
        {
            var total = _customerBasket.TotalNumberOfItems * 8.00m;
            return total;
        }

        //Discount is based on total number of unique books purchased
        public decimal CalculateDiscount()
        {
            
            var uniqueBooks = _customerBasket.Books.GroupBy(x => x.Name).Distinct().Count();
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

        public decimal CalculateGroupTotal()
        {
            CalculateGroups();

            var totalCost = 0.0m;
            foreach (var discountList in _discountGroups)
            {
                var total = discountList.Count * 8.00m;
                var discount = 0.0m;
                var disList = discountList.Count;
                switch (disList)
                {
                    case 0:
                        discount += 0.0m;
                        break;
                    case 1:
                        discount += 0.0m;
                        break;
                    case 2:
                        discount += 0.05m;
                        break;
                    case 3:
                        discount += 0.10m;
                        break;
                    case 4:
                        discount += 0.15m;
                        break;
                    case 5:
                        discount += 0.25m;
                        break;
                    case 6:
                        discount += 0.30m;
                        break;
                    case 7:
                        discount += 0.35m;
                        break;
                }


                var totalDiscount = total * discount;
                var finalPurchaseCost = total - totalDiscount;
                totalCost += finalPurchaseCost;
            }
          

            return totalCost;
        }

        public void CalculateGroups()
        {
            var discountLists = new List<List<string>>();
            //foreach (var book in _customerBasket.Books.GroupBy(x => x.Name).Distinct())
            // {

            foreach (var customerBook in _customerBasket.Books)
            {
                var listNotContainingBook = discountLists.Any(x => !x.Contains(customerBook.Name));
                if (listNotContainingBook) // if a list contains a book make a new one
                {
                    var list = discountLists.FirstOrDefault(x => !x.Contains(customerBook.Name));
                    list.Add(customerBook.Name);
                    //
                }
                else
                {
                    discountLists.Add(new List<string>() {customerBook.Name});
                }
            }

            _discountGroups = discountLists;
            //}
        }
    }
}