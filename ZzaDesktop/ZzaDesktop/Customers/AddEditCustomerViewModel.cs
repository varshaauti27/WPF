using Zza.Data;

namespace ZzaDesktop.Customers
{
    public class AddEditCustomerViewModel : BindableBase 
    {
        private bool _editMode;

        public bool EditMode
        {
            get { return _editMode; }
            set { SetProperty(ref _editMode, value); }
        }

        private Customer _editingCustomer = null;
        public void SetCustomer(Customer cust)
        {
            _editingCustomer = cust;
        }
    }
}
