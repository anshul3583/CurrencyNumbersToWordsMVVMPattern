using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyNumbersToWordsMVVMPattern.ViewModels
{  
    public class MvvmCommand : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// Initialize a new command
        /// </summary>
        /// <param name="execute">The delegate action</param>
        /// <param name="canExecute">The delegate condition to execute action</param>
        public MvvmCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            bool result = canExecute == null || canExecute(parameter);
            return result;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
