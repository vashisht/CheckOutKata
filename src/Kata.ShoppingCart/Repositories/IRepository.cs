using System.Collections.Generic;
using Kata.ShoppingCart.Entities;

namespace Kata.ShoppingCart.Repositories
{
    public interface IRepository
    {
        List<Item> GetItems();
    }
}