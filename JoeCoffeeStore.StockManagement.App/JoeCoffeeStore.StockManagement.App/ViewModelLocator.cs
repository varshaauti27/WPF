using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.ViewModel;
using JoeCoffeeStore.StockManagement.DAL;

namespace JoeCoffeeStore.StockManagement.App
{
    public class ViewModelLocator
    {
        private static IDialogService dialogService = new DialogService();
        private static ICoffeeDataService coffeeDataService = new CoffeeDataService(new CoffeeRepository());

        private static CoffeeOverviewViewModel coffeeOverviewViewModel = new CoffeeOverviewViewModel(coffeeDataService, dialogService);
        private static CoffeeDetailViewModel coffeeDetailViewModel = new CoffeeDetailViewModel(coffeeDataService, dialogService);

        public static CoffeeDetailViewModel CoffeeDetailViewModel
        {
            get
            {
                return coffeeDetailViewModel;
            }
        }

        public static CoffeeOverviewViewModel CoffeeOverviewViewModel
        {
            get
            {
                return coffeeOverviewViewModel;
            }
        }
    }
}
