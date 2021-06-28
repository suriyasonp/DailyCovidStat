using CovidStat.Main.Models;
using CovidStat.Main.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat.API.Services
{
    public class DailyCovidStatService : IDailyCovidStatService
    {
        public async Task<DailyCovidStatModel> GetDailyCovidStat()
        {
            using (CovidStatHttpClient client = new CovidStatHttpClient())
            {
                string uri = "getTodayCases.json";
                DailyCovidStatModel dailyCovidStat = await client.GetAsync<DailyCovidStatModel>(uri);
                return dailyCovidStat;
            }
           
        }
    }
}
