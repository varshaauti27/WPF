using JoeCoffeeStore.StockManagement.App.View;
using System.Windows;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    class DialogService : IDialogService
    {
        Window coffeeDetailView = null;

        public void CloseDetailDialog()
        {
            if (coffeeDetailView != null)
                coffeeDetailView.Close();
        }

        public void ShowDetailDialog()
        {
            coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.ShowDialog();
        }
    }
}
