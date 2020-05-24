using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CurrencyNumbersToWordsMVVMPattern.ViewModels
{
    public class ShellViewModel : INotifyPropertyChanged
    {
        private string currencyNumber;
        private string message = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; } = "Currency Numbers to Word Converter";       
        public ICommand ConverterCommand { get; set; }

        public string CurrencyNumber
        {
            get
            {
                return currencyNumber;
            }
            set
            {
                currencyNumber = value;
                OnPropertyChanged(nameof(CurrencyNumber));
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        #region ProcessButtonClick
        public ShellViewModel()
        {
            ConverterCommand = new MvvmCommand(ConverterButtonClicked, null);
        }


        private void ConverterButtonClicked(object obj)
        {
            try
            {
                Message = "";
                if (!string.IsNullOrEmpty(CurrencyNumber))
                {
                    ConverterServiceReference.Service svc = new ConverterServiceReference.Service();
                    var svcResponse = svc.ConvertCurrencyNumbersToWords(CurrencyNumber);
                    if (svcResponse != null)
                    {
                        Message = svcResponse.Result;
                    }
                }
                else
                {
                    Message = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Message = ex.Message;
            }
        }
        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
            if(propertyName == "CurrencyNumber")
            {
                Message = "";
            }
        }
    }
}
