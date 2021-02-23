using System.Collections.Generic;
using System.Linq;

namespace PotterKataLibrary
{
    public class Checkout
    {
        private readonly Basket _customerBasket;
        private List<List<string>> _uniqueBookGroup = new();

        public Checkout(Basket basket)
        {
            _customerBasket = basket;
        }

        public decimal CompletePurchase()
        {
            var total = Calculate();
            return total; 
        }

        public decimal CalculateTotal(int totalBooks,decimal discount)
        {
            var total = totalBooks * 8.00m;
            var totalDiscount = total * discount;
            var finalPurchaseCost = total - totalDiscount;
            return finalPurchaseCost;
        }

        public decimal GetDiscountRate(int totalBooks)
        {
            return totalBooks switch
            {
                0 => 0.0m,
                1 => 0.0m,
                2 => 0.05m,
                3 => 0.10m,
                4 => 0.15m,
                5 => 0.25m,
                6 => 0.30m,
                7 => 0.35m,
                _ => 0.0m
            };
    }

        public decimal Calculate()
        {
            CalculateDiscountGroups();

            var totalCost = 0.0m;
            foreach (var discountList in _uniqueBookGroup)
            {
            
                var distinctBookList = discountList.Count;

                var discount = GetDiscountRate(distinctBookList);

                totalCost += CalculateTotal(distinctBookList, discount);
            }
          

            return totalCost;
        }

        public void CalculateDiscountGroups()
        {
            var discountLists = new List<List<string>>();

            foreach (var customerBook in _customerBasket.Books)
            {
                var listNotContainingBook = discountLists.Any(x => !x.Contains(customerBook.Name));
                if (listNotContainingBook) // if a list dosent contains a book add it
                {
                    var list = discountLists.FirstOrDefault(x => !x.Contains(customerBook.Name));
                    list.Add(customerBook.Name);
                }
                else
                {
                    discountLists.Add(new List<string>() {customerBook.Name});
                }
            }

            _uniqueBookGroup = discountLists;
        }
    }
}