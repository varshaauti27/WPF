using JoeCoffeeStore.StockManagement.Model;
using System.Collections.Generic;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    public interface ICoffeeDataService
    {
        void DeleteCoffee(Coffee coffee);
        List<Coffee> GetAllCoffees();
        Coffee GetCoffeeDetail(int coffeeId);
        void UpdateCoffee(Coffee coffee);
    }
}
