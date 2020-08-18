using JoeCoffeeStore.StockManagement.Model;
using System.Collections.Generic;
namespace JoeCoffeeStore.StockManagement.DAL
{
    public interface ICoffeeRepository
    {
        void DeleteCoffee(Coffee coffee);
        Coffee GetACoffee();
        Coffee GetCoffeeById(int id);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
    }
}
