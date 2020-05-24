using CurrencyNumbersToWordsMVVMPattern.App_Start;
using System.Windows;

namespace CurrencyNumbersToWordsMVVMPattern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new Bootstrapper().Run();
        }
    }
}
