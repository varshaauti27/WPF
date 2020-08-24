using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.Utility;
using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class ValidationDemoViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private IDialogService dialogService;
        public ValidationDemoViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
        }

        private int age;
        private int validAge;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                RaisePropertyChanged(nameof(age));
            }
        }

        public int ValidAge
        {
            get
            {
                return validAge;
            }
            set
            {
                if (value < 10 || value > 100)
                    throw new ArgumentException("The age must be between 10 and 100");

                validAge = value;
                RaisePropertyChanged(nameof(validAge));
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Age":
                        if (this.Age < 10 || this.Age > 100)
                            return "The age must be between 10 and 100";
                        break;
                }

                return string.Empty;
            }
        }
    }
}
