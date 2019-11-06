using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfWeather.Model;

namespace WpfWeather.ViewModel
{
    public class AccuWeatherApi
    {
        public const string BASE_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}";

        public async Task<AccuWeather> GetWeatherAsync(int locationKey)
        {
            AccuWeather weather = new AccuWeather();
            string url = string.Format(BASE_URL, locationKey);

            UriBuilder builder = new UriBuilder(url);
            builder.Query = $"apikey={ConfigurationManager.AppSettings["API_KEY"]}&metric=true";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(builder.Uri);
                var json = await response.Content.ReadAsStringAsync();

                weather = JsonConvert.DeserializeObject<AccuWeather>(json);
            }

            return weather;

        }
    }
}
