using Kata.ShoppingCart.Repositories;

namespace Kata.ShoppingCart.Domain
{
    public class PriceFinder: IPriceFinder
    {
        public PriceFinder()
        {
            
        }
        public int PriceFor(string item)
        {
            var repository = new Repository();
            return 80;
        }
    }
}