using JoeCoffeeStore.StockManagement.App.View;
using System.Windows;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    class DialogService : IDialogService
    {
        Window dialogWindow = null;

        public void CloseDetailDialog()
        {
            if (dialogWindow != null)
                dialogWindow.Close();
        }

        public void ShowDetailDialog(bool isValidationDialog = false)
        {
            if (isValidationDialog)
            {
                dialogWindow = new ValidationDemo();
            }
            else
            {
                dialogWindow = new CoffeeDetailView();
            }
            dialogWindow.ShowDialog();
        }
    }
}
