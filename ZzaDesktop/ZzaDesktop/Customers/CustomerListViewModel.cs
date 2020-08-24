using System;
using System.Collections.ObjectModel;
using Zza.Data;
using ZzaDesktop.Services;

namespace ZzaDesktop.Customers
{
    public class CustomerListViewModel : BindableBase
    {
        private ICustomersRepository repo = new CustomersRepository();

        private ObservableCollection<Customer> _customers;

        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }
            set { SetProperty(ref _customers, value); }
        }

        public CustomerListViewModel()
        {
            PlaceOrderCommand = new RelayCommand<Customer>(OnPlaceOrder);
            AddCustomerCommand = new RelayCommand(OnAddCustomer);
            EditCustomerCommand = new RelayCommand<Customer>(OnEditCustomer);
        }

        private void OnEditCustomer(Customer cust)
        {
            EditCustomerRequested(cust);
        }

        private void OnAddCustomer()
        {
            AddCustomerRequested(new Customer { Id = Guid.NewGuid() });
        }

        public event Action<Guid> PlaceOrderRequested = delegate { };
        public event Action<Customer> AddCustomerRequested = delegate { };
        public event Action<Customer> EditCustomerRequested = delegate { };

        private void OnPlaceOrder(Customer customer)
        {
            PlaceOrderRequested(customer.Id);
            //repo.AddCustomerAsync(customer);
        }

        public async void LoadCustomer()
        {
            Customers = new ObservableCollection<Customer>(await repo.GetCustomersAsync());
        }

        public RelayCommand<Customer> PlaceOrderCommand { get; private set; }
        public RelayCommand AddCustomerCommand { get; private set; }
        public RelayCommand<Customer> EditCustomerCommand { get; private set; }

    } 
}
