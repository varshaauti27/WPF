﻿using System.Windows.Controls;

namespace JoeCoffeeStore.StockManagement.App.View
{
    public class StringToIntValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int i;
            if (int.TryParse(value.ToString(), out i))
                return new ValidationResult(true, null);

            return new ValidationResult(false, "Please enter a valid integer value!");
        }
    }
}
