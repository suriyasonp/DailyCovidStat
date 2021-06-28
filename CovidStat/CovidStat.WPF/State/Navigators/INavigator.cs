using CovidStat.WPF.ViewModels;
using System.Windows.Input;

namespace CovidStat.WPF.State.Navigators
{
    public enum ViewType
    {
        Daily,
        Detail
    }
    public interface INavigator
    {       
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
