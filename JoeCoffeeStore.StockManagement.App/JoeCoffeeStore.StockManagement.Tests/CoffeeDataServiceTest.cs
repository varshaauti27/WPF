using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Tests.Mocks;
using JoeCoffeeStore.StockManagement.DAL;

namespace JoeCoffeeStore.StockManagement.Tests
{
    [TestClass]
    public class CoffeeDataServiceTest
    {

        private ICoffeeRepository repository;


        [TestInitialize]
        public void Init()
        {
            repository = new MockRepository();
        }

        [TestMethod]
        public void GetCoffeeDetailTest()
        {
            //arrange
            var service = new CoffeeDataService(repository);

            //act
            var coffee = service.GetCoffeeDetail(1);

            //assert
            Assert.IsNotNull(coffee);

        }
    }
}
