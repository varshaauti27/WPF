using JoeCoffeeStore.StockManagement.App.Messages;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.Utility;
using JoeCoffeeStore.StockManagement.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeDetailViewModel: INotifyPropertyChanged, ICoffeeDetailViewModel
    {
        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogService;
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private Coffee selectedCoffee;
        public Coffee SelectedCoffee
        {
            get
            {
                return selectedCoffee;
            }
            set
            {
                selectedCoffee = value;
                RaisePropertyChanged("SelectedCoffee");
            }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public CoffeeDetailViewModel(ICoffeeDataService coffeeDataService, IDialogService dialogService)
        {
            this.coffeeDataService = coffeeDataService;
            this.dialogService = dialogService;

            SaveCommand = new CustomCommand(SaveCoffee, CanSaveCoffee);
            DeleteCommand = new CustomCommand(DeleteCoffee, CanDeleteCoffee);

            Messenger.Default.Register<Coffee>(this, OnCoffeeReceived);
        }

        private void OnCoffeeReceived(Coffee coffee)
        { 
            SelectedCoffee = coffee;
        }

        private bool CanDeleteCoffee(object obj)
        {
            return true;
        }

        private void DeleteCoffee(object obj)
        {
            coffeeDataService.DeleteCoffee(selectedCoffee);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());

            dialogService.CloseDetailDialog();
        }

        private bool CanSaveCoffee(object obj)
        {
            return true;
        }

        private void SaveCoffee(object obj)
        {
            coffeeDataService.UpdateCoffee(selectedCoffee);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());

            dialogService.CloseDetailDialog();
        }
    }
}
