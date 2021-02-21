using System.Collections.Generic;
using System.Linq;

namespace PotterKataLibrary
{
    public class Checkout
    {
        private readonly Basket _customerBasket;
        private List<List<string>> _discountGroups = new();

        public Checkout(Basket basket)
        {
            _customerBasket = basket;
        }


        public decimal CompletePurchase()
        {
            
            var standardDiscount = CalculateStandardTotal();
            var groupDiscount = CalculateGroupTotal();

           return  groupDiscount > standardDiscount ? groupDiscount : standardDiscount;
        }

        public decimal CalculateTotal()
        {
            var total = _customerBasket.TotalNumberOfItems * 8.00m;
            return total;
        }

        //Basic discount is based on total number of unique books purchased
        public decimal CalculateStandardTotal()
        {
            var discount = 0.0m;
            var uniqueBooks = _customerBasket.Books.GroupBy(x => x.Name).Distinct().Count();
            switch (uniqueBooks)
            {
                case 0:
                    discount =  0.0m;
                    break;
                case 1:
                    discount =  0.0m;
                    break;
                case 2:
                    discount =  0.05m;
                    break;
                case 3:
                    discount =  0.10m;
                    break;
                case 4:
                    discount = 0.15m;
                    break;
                case 5:
                    discount = 0.25m;
                    break;
                case 6:
                    discount = 0.30m;
                    break;
                case 7:
                    discount = 0.35m;
                    break;
            }
            var total = CalculateTotal();
            var totalDiscount = total * discount;
            var finalPurchaseCost = total - totalDiscount;
            return finalPurchaseCost;
        }

        public decimal CalculateGroupTotal()
        {
            CalculateDiscountGroups();

            var totalCost = 0.0m;
            foreach (var discountList in _discountGroups)
            {
                var total = discountList.Count * 8.00m;
                var discount = 0.0m;
                var disList = discountList.Count;
                switch (disList) //todo: Abstract to classes or own function
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

            _discountGroups = discountLists;
        }
    }
}