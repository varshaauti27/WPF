using System;
using System.Windows.Data;
using System.Windows.Media;

namespace JoeCoffeeStore.StockManagement.App.Converter
{
    public class AmountInStockConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int amount = (int)value;
            if (amount == 0)
                return new SolidColorBrush(Colors.Gold);
            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
