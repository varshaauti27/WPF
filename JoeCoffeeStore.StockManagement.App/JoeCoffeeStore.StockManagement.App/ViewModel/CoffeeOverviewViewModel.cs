using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using JoeCoffeeStore.StockManagement.App.Extensions;
using System.Windows.Input;
using JoeCoffeeStore.StockManagement.App.Utility;
using JoeCoffeeStore.StockManagement.App.Messages;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged, ICoffeeOverviewViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogService;
        public ICommand EditCommand { get; set; }

        private ObservableCollection<Coffee> coffees;
        public ObservableCollection<Coffee> Coffees
        {
            get
            {
                return coffees;
            }
            set
            {
                coffees = value;
                RaisePropertyChanged("Coffees");
            }
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

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public CoffeeOverviewViewModel(ICoffeeDataService coffeeDataService,IDialogService dialogService)
        {
            this.coffeeDataService = coffeeDataService;
            this.dialogService = dialogService;

            LoadData();
            LoadCommand();

            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }

        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            dialogService.CloseDetailDialog();
        }

        private void LoadCommand()
        {
            EditCommand = new CustomCommand(EditCoffee, CanEditCoffee);
        }

        private bool CanEditCoffee(object obj)
        {
            if (SelectedCoffee != null)
                return true;
            return false;
        }

        private void EditCoffee(object obj)
        {
            Messenger.Default.Send<Coffee>(selectedCoffee);
            dialogService.ShowDetailDialog();
        }

        private void LoadData()
        {
            Coffees = coffeeDataService.GetAllCoffees().ToObservableCollection();
        }

    }
}
