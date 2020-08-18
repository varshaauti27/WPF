using JoeCoffeeStore.StockManagement.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public interface ICoffeeDetailViewModel
    {
        ICommand DeleteCommand { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
        ICommand SaveCommand { get; set; }
        Coffee SelectedCoffee { get; set; }
    }
}
