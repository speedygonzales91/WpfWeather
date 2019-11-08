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
        public const string BASE_URL_AUTOCOMPLETE = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete";

        public static async Task<AccuWeather> GetWeatherAsync(string locationKey)
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

        public static async Task<List<City>> GetCityAutoComplete(string searchString)
        {
            List<City> cities = new List<City>();
            UriBuilder builder = new UriBuilder(BASE_URL_AUTOCOMPLETE);
            builder.Query = $"apikey={ConfigurationManager.AppSettings["API_KEY"]}&q={searchString}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(builder.Uri);
                var json = await response.Content.ReadAsStringAsync();

                cities = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return cities;
        }
    }
}
