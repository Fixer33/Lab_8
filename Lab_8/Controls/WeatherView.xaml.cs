using Lab_8.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_8.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherView : ContentView
    {
        public static readonly BindableProperty HeaderTextProperty = 
            BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(WeatherView), default(string), defaultBindingMode: BindingMode.OneWay, 
                propertyChanged: HeaderTextPropertyChanged);

        private static void HeaderTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (WeatherView)bindable;
            control.headerText.Text = newValue.ToString();
        }

        public string HeaderText
        {
            get => (string)GetValue(HeaderTextProperty); 
            set => SetValue(HeaderTextProperty, value);
        }

        private WeatherViewModel _model;

        public WeatherView()
        {
            InitializeComponent();

            BindingContext = _model = new WeatherViewModel();
        }

        public void SetInfo(DataItem data)
        {
            weatherTypeLabel.Text = GetWeatherType(data.Weather[0].Main);
            temperatureLabel.Text = data.Main.Temp.ToString() + " °C";
            feelsLikeLabel.Text = data.Main.FeelsLike.ToString() + " °C";
            pressureLabel.Text = data.Main.Pressure.ToString();
            humidityLabel.Text = data.Main.Humidity.ToString() + " %";
            windSpeedLabel.Text = data.Wind.Speed.ToString() + " м/c";
        }

        private string GetWeatherType(string eng)
        {
            switch (eng)
            {
                case "Clear":
                    return "Ясно";
                case "Sunny":
                    return "Солнечно";
                case "Rain":
                    return "Дождь";
                case "Clouds":
                    return "Облачно";
                default:
                    return eng;
            };
        }
    }
}