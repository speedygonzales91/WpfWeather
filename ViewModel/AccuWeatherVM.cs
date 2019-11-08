using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWeather.Model;
using WpfWeather.ViewModel.Commands;

namespace WpfWeather.ViewModel
{
    public class AccuWeatherVM
    {
        //This will hold the info for View
        public AccuWeather Weather { get; set; }

        private string _query;

        public string Query
        {
            get { return _query; }
            set { 
                _query = value;
                GetCity();
            }
        }

        public ObservableCollection<City> Cities { get; set; }

        public RefreshCommand Command { get; set; }


        private City _selectedCity;

        public City SelectedCity
        {
            get { return _selectedCity; }
            set 
            { 
                _selectedCity = value;
                //GetWeather();
            }
        }


        public AccuWeatherVM()
        {
            Weather = new AccuWeather();
            Cities = new ObservableCollection<City>();
            Command = new RefreshCommand(this);
        }

        private async void GetCity()
        {
            var response = await AccuWeatherApi.GetCityAutoComplete(Query);

            Cities.Clear();

            foreach (var city in response)
            {
                Cities.Add(city);
            }
        }

        public async void GetWeather()
        {
            var response = await AccuWeatherApi.GetWeatherAsync(SelectedCity.Key);
            Weather.DailyForecasts = response.DailyForecasts;
        }
    }
}
