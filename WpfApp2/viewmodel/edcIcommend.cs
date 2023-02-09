using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp2.model;

namespace WpfApp2.viewmodel
{
    public class edcIcommend : ICommand
    {
        
        public event EventHandler? CanExecuteChanged;
        public Action<object> Action;
        public Func<bool> Func { get; set; }
        public edcIcommend(Action<object> Action)
        {
            this.Action = Action;
        }

        public bool CanExecute(object? parameter)
        {
            if (Func == null)
            {
                return true;
            }
            else { return false; }
        }

        public void Execute(object? parameter)
        {
            Action?.Invoke(parameter);

        }
    }
}
