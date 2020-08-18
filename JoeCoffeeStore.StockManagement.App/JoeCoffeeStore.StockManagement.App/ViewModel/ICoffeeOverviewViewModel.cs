using JoeCoffeeStore.StockManagement.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public interface ICoffeeOverviewViewModel
    {
        ObservableCollection<Coffee> Coffees { get; set; }
        ICommand EditCommand { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        Coffee SelectedCoffee { get; set; }
    }
}
