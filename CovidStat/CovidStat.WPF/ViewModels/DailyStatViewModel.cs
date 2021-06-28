using CovidStat.Main.Services;

namespace CovidStat.WPF.ViewModels
{
    public class DailyStatViewModel : ViewModelBase
    {
        public readonly IDailyCovidStatService _dailyCovidStatService;

        public DailyStatViewModel(IDailyCovidStatService dailyCovidStatService)
        {
            _dailyCovidStatService = dailyCovidStatService;
            LoadDailyStat();
        }

        //public static DailyStatViewModel LoadDailyStatViewModel(IDailyCovidStatService dailyCovidStatService)
        //{            
        //    DailyStatViewModel dailyStatViewModel = new DailyStatViewModel(dailyCovidStatService);
        //    dailyStatViewModel.LoadDailyStat();
        //    return dailyStatViewModel;
        //}

        private void LoadDailyStat()
        {           
            _dailyCovidStatService.GetDailyCovidStat();
        }
    }
}
