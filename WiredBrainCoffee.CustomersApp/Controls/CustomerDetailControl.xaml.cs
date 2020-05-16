using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Controls
{
  [ContentProperty(Name = nameof(Customer))]
  public sealed partial class CustomerDetailControl : UserControl
  {
    public static readonly DependencyProperty CustomerProperty =
        DependencyProperty.Register("Customer", typeof(Customer),
          typeof(CustomerDetailControl), new PropertyMetadata(null));

    public CustomerDetailControl()
    {
      this.InitializeComponent();
    }

    public Customer Customer
    {
      get { return (Customer)GetValue(CustomerProperty); }
      set { SetValue(CustomerProperty, value); }
    }
  }
}
