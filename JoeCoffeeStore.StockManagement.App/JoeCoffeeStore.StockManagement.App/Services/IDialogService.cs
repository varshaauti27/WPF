namespace JoeCoffeeStore.StockManagement.App.Services
{
    public interface IDialogService
    {
        void CloseDetailDialog();
        void ShowDetailDialog(bool isValidationDialog = false);
    }
}
