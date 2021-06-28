using CovidStat.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat.Main.Services
{
    public interface IDailyCovidStatService
    {
        Task<DailyCovidStatModel> GetDailyCovidStat();
    }
}
