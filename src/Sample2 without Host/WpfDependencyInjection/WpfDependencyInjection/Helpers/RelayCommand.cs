using System;
using System.Windows.Input;

namespace WpfDependencyInjection
{
    public sealed class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;
        private readonly Action executeNoParam;
        private readonly Func<bool> canExecuteNoParam;
        private readonly bool useNoParam;

        public RelayCommand(Action<object> execute)
        {
            this.execute = execute;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action execute)
        {
            executeNoParam = execute;

            useNoParam = true;
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            executeNoParam = execute;
            canExecuteNoParam = canExecute;

            useNoParam = true;
        }

        public void Execute(object parameter)
        {
            if (useNoParam)
            {
                executeNoParam?.Invoke();
            }
            else
            {
                execute?.Invoke(parameter);
            }
        }

        public bool CanExecute(object parameter)
        {
            if (useNoParam)
            {
                return canExecuteNoParam == null || canExecuteNoParam.Invoke();
            }
            else
            {
                return canExecute == null || canExecute.Invoke(parameter);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
