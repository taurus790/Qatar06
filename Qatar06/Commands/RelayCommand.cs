using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Input;

namespace Qatar06.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action DoWork; // Delegate. 

        // Constructor. 
        public RelayCommand(Action work)
        {
            DoWork = work;
        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();

            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();

            DoWork();
        }
    }
}