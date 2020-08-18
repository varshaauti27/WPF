using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Tests.Mocks;
using JoeCoffeeStore.StockManagement.App.ViewModel;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.ObjectModel;

namespace JoeCoffeeStore.StockManagement.Tests
{
    [TestClass]
    public class CoffeeOverviewViewModelTests
    {
        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogService;

        private CoffeeOverviewViewModel GetViewModel()
        {
            return new CoffeeOverviewViewModel(this.coffeeDataService, this.dialogService);
        }

        [TestInitialize]
        public void Init()
        {
            coffeeDataService = new MockCoffeeDataService();
            dialogService = new MockDialogService();
        }

        [TestMethod]
        public void LoadAllCoffees()
        {
            //Arrange
            ObservableCollection<Coffee> coffees = null;
            var expectedCoffees = coffeeDataService.GetAllCoffees();
            
            //act
            var viewModel = GetViewModel();
            coffees = viewModel.Coffees;

            //assert
            CollectionAssert.AreEqual(expectedCoffees, coffees);
        }
    }
}
