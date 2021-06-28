using CovidStat.API.Services;
using CovidStat.Main.Models;
using CovidStat.Main.Services;

namespace CovidStat.WPF.Models
{
    public class DailyStatViewModel : ViewModelBase
    {
        public readonly IDailyCovidStatService _dailyCovidStatService;

        public DailyStatViewModel(IDailyCovidStatService dailyCovidStatService)
        {
            _dailyCovidStatService = dailyCovidStatService;
        }

        public static DailyStatViewModel LoadDailyStatViewModel(IDailyCovidStatService dailyCovidStatService)
        {            
            DailyStatViewModel dailyStatViewModel = new DailyStatViewModel(dailyCovidStatService);
            dailyStatViewModel.LoadDailyStat();
            return dailyStatViewModel;
        }

        private void LoadDailyStat()
        {           
            _dailyCovidStatService.GetDailyCovidStat();
        }
    }
}
