using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfWeather.ViewModel.Commands
{
    public class RefreshCommand : ICommand
    {

        public AccuWeatherVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public RefreshCommand(AccuWeatherVM vm)
        {
            VM = vm;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.GetWeather();
        }
    }
}
