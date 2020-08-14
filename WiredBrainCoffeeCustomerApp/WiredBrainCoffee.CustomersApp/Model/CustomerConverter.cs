namespace WiredBrainCoffee.CustomersApp.Model
{
  public static class CustomerConverter
  {
    public static Customer CreateCustomerFromString(string inputString)
    {
      var values = inputString.Split(',');
      return new Customer
      {
        FirstName = values[0],
        LastName = values[1],
        IsDeveloper = bool.Parse(values[2])
      };
    }
  }
}
