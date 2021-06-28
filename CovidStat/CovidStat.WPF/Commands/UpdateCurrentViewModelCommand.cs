using CovidStat.API.Services;
using CovidStat.WPF.State.Navigators;
using CovidStat.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace CovidStat.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Daily:
                        _navigator.CurrentViewModel = new DailyStatViewModel(new DailyCovidStatService());
                        break;
                    case ViewType.Detail:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
