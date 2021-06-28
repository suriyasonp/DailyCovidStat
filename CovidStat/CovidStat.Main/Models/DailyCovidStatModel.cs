using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat.Main.Models
{
    public class DailyCovidStatModel
    {
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Hospitalized { get; set; }
        public int Deaths { get; set; }
        public int NewConfirmed { get; set; }
        public int NewRecovered { get; set; }
        public int NewHospitalized { get; set; }
        public int NewDeaths { get; set; }
        public int UpdateDate { get; set; }
    }
}
