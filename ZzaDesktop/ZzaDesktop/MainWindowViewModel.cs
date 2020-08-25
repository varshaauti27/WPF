using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;
using ZzaDesktop.Customers;
using ZzaDesktop.OrderPrep;
using ZzaDesktop.Orders;
using ZzaDesktop.Services;

namespace ZzaDesktop
{
    public class MainWindowViewModel : BindableBase
    {
        private CustomerListViewModel _customerListViewModel;
        private OrderPrepViewModel _orderPrepViewModel = new OrderPrepViewModel();
        private OrderViewModel _orderViewModel = new OrderViewModel();
        private AddEditCustomerViewModel _addEditCustomerViewModel;
        private ICustomersRepository repo = new CustomersRepository();

        public RelayCommand<string> NavCommand { get; private set; }
        private BindableBase _currentViewModel;

        public MainWindowViewModel()
        {
            _customerListViewModel = new CustomerListViewModel(repo);
            _addEditCustomerViewModel = new AddEditCustomerViewModel(repo);
            NavCommand = new RelayCommand<string>(OnNav);
            _customerListViewModel.PlaceOrderRequested += NavToOrder;
            _customerListViewModel.AddCustomerRequested += NavToAddCustomer;
            _customerListViewModel.EditCustomerRequested += NavToEditCustomer;
            _addEditCustomerViewModel.Done += NavToCustomerList;
        }

        private void NavToCustomerList()
        {
            CurrentViewModel = _customerListViewModel;
        }

        private void NavToEditCustomer(Customer cust)
        {
            _addEditCustomerViewModel.EditMode = true;
            _addEditCustomerViewModel.SetCustomer(cust);
            CurrentViewModel = _addEditCustomerViewModel;
        }

        private void NavToAddCustomer(Customer cust)
        {
            _addEditCustomerViewModel.EditMode = false;
            _addEditCustomerViewModel.SetCustomer(cust);
            CurrentViewModel = _addEditCustomerViewModel;
        }

        private void NavToOrder(Guid customerId)
        {
            _orderViewModel.CustomerId = customerId;
            CurrentViewModel = _orderViewModel;
        }

        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                SetProperty(ref _currentViewModel,value);
            }
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "orderPrep":
                    CurrentViewModel = _orderPrepViewModel;
                    break;
                case "customer":
                    CurrentViewModel = _customerListViewModel;
                    break;
            }
        
        }
    }
}
