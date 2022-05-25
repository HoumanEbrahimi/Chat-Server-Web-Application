using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    public class RelayCommand : ICommand
    {
        private readonly Func<object, bool> canExecute;
        private Action<object> execute;
        private Func<object, bool> p;

        // public RelayCommand(Func<object, bool> p)
        // {
        //     this.p = p;
        // }

        public RelayCommand(Action<object> action)
            : this(x => true, action)
        {
            execute = action;
        }

        public RelayCommand(Func<object, bool> canExecute, Action<object> execute)
        {

            this.canExecute = canExecute;
            this.execute = execute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }


        public void Execute(object parameter)
        {
            //execute((T)parameter);
            this.execute(parameter);
            //UpdateCanExecuteState();
        }
    }
}

