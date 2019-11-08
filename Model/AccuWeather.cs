using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWeather.Model
{
    //public class Headline
    //{
    //    public DateTime EffectiveDate { get; set; }
    //    public int EffectiveEpochDate { get; set; }
    //    public int Severity { get; set; }
    //    public string Text { get; set; }
    //    public string Category { get; set; }
    //    public DateTime EndDate { get; set; }
    //    public int EndEpochDate { get; set; }
    //    public string MobileLink { get; set; }
    //    public string Link { get; set; }
    //}

    public class Minimum : INotifyPropertyChanged
    {
        private double _value;

        public double Value
        {
            get { return _value; }
            set 
            { 
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set 
            { 
                _unit = value;
                OnPropertyChanged("Unit");
            }
        }

        private int _unitType;

        public int UnitType
        {
            get { return _unitType; }
            set 
            { 
                _unitType = value;
                OnPropertyChanged("UnitType");
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

    public class Maximum : INotifyPropertyChanged
    {
        private double _value;

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
                OnPropertyChanged("Unit");
            }
        }

        private int _unitType;

        public int UnitType
        {
            get { return _unitType; }
            set
            {
                _unitType = value;
                OnPropertyChanged("UnitType");
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

    public class Temperature : INotifyPropertyChanged
    {
        private Minimum _minimum;

        public Minimum Minimum
        {
            get { return _minimum; }
            set 
            {
                _minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        private Maximum _maximum;

        public Maximum Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                OnPropertyChanged("Maximum");
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

    public class Day : INotifyPropertyChanged
    {
        private int _icon;

        public int Icon
        {
            get { return _icon; }
            set 
            { 
                _icon = value;
                OnPropertyChanged("Icon");
            }
        }

        private string _iconPhrase;

        public string IconPhrase
        {
            get { return _iconPhrase; }
            set 
            { 
                _iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        private bool _hasPrecipitation;

        public bool HasPrecipitation
        {
            get { return _hasPrecipitation; }
            set 
            { 
                _hasPrecipitation = value;
                OnPropertyChanged("HasPrecipitation");
            }
        }

        private string _precipitationType;

        public string PrecipitationType
        {
            get { return _precipitationType; }
            set 
            { 
                _precipitationType = value;
                OnPropertyChanged("PrecipitationType");
            }
        }

        private string _precipitationIntesity;

        public string PrecipitationIntesity
        {
            get { return _precipitationIntesity; }
            set 
            { 
                _precipitationIntesity = value;
                OnPropertyChanged("PrecipitationIntesity");
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

    //public class Night
    //{
    //    public int Icon { get; set; }
    //    public string IconPhrase { get; set; }
    //    public bool HasPrecipitation { get; set; }
    //    public string PrecipitationType { get; set; }
    //    public string PrecipitationIntensity { get; set; }
    //}

    public class DailyForecast : INotifyPropertyChanged
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set 
            { 
                _date = value;
                OnPropertyChanged("Date");
            }
        }

        private int _epochDate;

        public int EpochDate
        {
            get { return _epochDate; }
            set 
            { 
                _epochDate = value;
                OnPropertyChanged("EpochDate");
            }
        }


        private Temperature _temperature;

        public Temperature Temperature
        {
            get { return _temperature; }
            set 
            { 
                _temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        private Day _day;

        public Day Day
        {
            get { return _day; }
            set 
            {
                _day = value;
                OnPropertyChanged("Day");
            }
        }

        private Day _night;

        public Day Night
        {
            get { return _night; }
            set 
            { 
                _night = value;
                OnPropertyChanged("Night");
            }
        }

        private IList<string> _sources;

        public IList<string> Sources
        {
            get { return _sources; }
            set 
            {
                _sources = value;
                OnPropertyChanged("Sources");
            }
        }


        //public string MobileLink { get; set; }
        //public string Link { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class AccuWeather : INotifyPropertyChanged
    {
        //public Headline Headline { get; set; }

        private IList<DailyForecast> _dailyForecasts;

        public IList<DailyForecast> DailyForecasts
        {
            get { return _dailyForecasts; }
            set 
            { 
                _dailyForecasts = value;
                OnPropertyChanged("DailyForecasts");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public AccuWeather()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                _dailyForecasts = new List<DailyForecast>();

                for (int i = 0; i < 3; i++)
                {
                    DailyForecast dailyForecast = new DailyForecast()
                    {
                        Date = DateTime.Now.AddDays(-1),
                        Temperature = new Temperature()
                        {
                            Minimum = new Minimum()
                            {
                                Value = 2 + i,
                                Unit = "°C"
                            }
                            ,
                            Maximum = new Maximum()
                            {
                                Value = 12 + i,
                                Unit = "°C"
                            }
                        }
                    };
                    _dailyForecasts.Add(dailyForecast);
                }
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
