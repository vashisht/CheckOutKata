namespace Kata.ShoppingCart.Domain
{
    public interface IPriceFinder
    {
        int PriceFor(string item);
    }
}
