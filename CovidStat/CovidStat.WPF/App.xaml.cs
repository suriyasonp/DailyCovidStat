using CovidStat.API.Services;
using CovidStat.WPF.Models;
using CovidStat.WPF.ViewModels;
using CovidStat.WPF.Views;
using System.Windows;

namespace CovidStat.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Window window = new DailyCovidStatView();
            window.DataContext = new DailyStatViewModel(new DailyCovidStatService());
            window.Show();
            base.OnStartup(e);
        }

    }
}
