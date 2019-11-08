using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeather.Model
{
    public class Area : INotifyPropertyChanged
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set 
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }


        private string _localizedName;

        public string LocalizedName
        {
            get { return _localizedName; }
            set 
            { 
                _localizedName = value;
                OnPropertyChanged("LocalizedName");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class City : INotifyPropertyChanged
    {
        private string _key;

        public string Key
        {
            get { return _key; }
            set 
            { 
                _key = value;
                OnPropertyChanged("Key");
            }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set 
            { 
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        private string _localizedName;

        public string LocalizedName
        {
            get { return _localizedName; }
            set 
            {
                _localizedName = value;
                OnPropertyChanged("LocalizedName");
            }
        }

        private Area _country;

        public Area Country
        {
            get { return _country; }
            set 
            { 
                _country = value;
                OnPropertyChanged("Country");
            }
        }

        private Area _administrativeArea;

        public Area AdministrativeArea
        {
            get { return _administrativeArea; }
            set 
            { 
                _administrativeArea = value;
                OnPropertyChanged("AdministrativeArea");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


    //public class CityResult : INotifyPropertyChanged
    //{
    //    private IList<City> _cities;

    //    public IList<City> Cities
    //    {
    //        get { return _cities; }
    //        set 
    //        {
    //            _cities = value;
    //            OnPropertyChanged("Cities");
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void OnPropertyChanged(string propertyName)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}
}
