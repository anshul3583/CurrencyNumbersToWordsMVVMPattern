
using CurrencyNumbersToWordsMVVMPattern.Views;
using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Ioc;
using Unity;

namespace CurrencyNumbersToWordsMVVMPattern.App_Start
{ 
    /* Anshul - I have been used prism unity version 6.3, boot strapper is obeselete in version 7.2...
     * have to read about implementation with 7.2 prism version.
     * For the purpose of this project, supressing the warning.
    */
#pragma warning disable CS0618 // Type or member is obsolete
    public class Bootstrapper : UnityBootstrapper
#pragma warning restore CS0618 // Type or member is obsolete
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
