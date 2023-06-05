using Lab_8.Models;
using Lab_8.ViewModels;
using Lab_8.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_8.Views
{
    public partial class TomorrowForecastPage : ContentPage
    {
        TomorrowForecastViewModel _viewModel;

        public TomorrowForecastPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new TomorrowForecastViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();

            var forecast = await WeatherData.GetForecast();

            var todayRecords = forecast.Where(item => DateTimeOffset.FromUnixTimeSeconds(item.Dt).UtcDateTime.DayOfYear == DateTime.UtcNow.DayOfYear + 1).ToArray();
            for (int i = 0; i < todayRecords.Length; i++)
            {
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(forecast[i].Dt);
                DateTime date = dateTimeOffset.UtcDateTime;
                
                if (date.Hour == 6)
                {
                    morningInfo.SetInfo(todayRecords[i]);
                }

                if (date.Hour == 15)
                {
                    dayInfo.SetInfo(todayRecords[i]);
                }

                if (date.Hour == 21)
                {
                    eveningInfo.SetInfo(todayRecords[i]);
                }
            }
        }
    }
}