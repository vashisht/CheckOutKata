using System.Collections.Generic;
using System.Globalization;
using Kata.ShoppingCart.Domain;

namespace Kata.ShoppingCart
{
    public class Checkout
    {
        private readonly IDiscounter _discounter;
        private readonly IPriceFinder _priceFinder;
        private Dictionary<string, int> _DiscountRules;
        private int _total;

        public Checkout(IDiscounter discounter, IPriceFinder priceFinder)
        {
            _discounter = discounter;
            _priceFinder = priceFinder;
            _total = 0;
        }

        public int Total()
        {
            return _total;
        }

        public void Scan(string items)
        {
            foreach (var item in items.ToCharArray())
            {
                var discount = _discounter.DiscountFor(item.ToString(CultureInfo.InvariantCulture));
               // AddToDiscountRules(item.ToString(CultureInfo.InvariantCulture),discount);
                _total += _priceFinder.PriceFor(item.ToString(CultureInfo.InvariantCulture));
               // _total -= discount;
            }
        }

//        private void AddToDiscountRules(string item, int discount)
//        {
//           _DiscountRules.Add(item,discount);
//        }
    }
}
