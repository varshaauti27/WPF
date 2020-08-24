using JoeCoffeeStore.StockManagement.App.Services;

namespace JoeCoffeeStore.StockManagement.Tests.Mocks
{
    public class MockDialogService: IDialogService
    {
        public void CloseDetailDialog()
        {
            
        }

        public void ShowDetailDialog(bool isValidationDialog = false)
        {
            throw new System.NotImplementedException();
        }
    }
}
