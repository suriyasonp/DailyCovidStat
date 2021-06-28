using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat.API
{
    public class CovidStatHttpClient : HttpClient
    {
        public CovidStatHttpClient()
        {
            this.BaseAddress = new Uri("https://covid19.th-stat.com/json/covid19v2/");
        }

        public async Task<T> GetAsync<T>(String uri)
        {
            HttpResponseMessage responseMessage = await GetAsync(uri);
            string jsonResponse = await responseMessage.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

    }
}
