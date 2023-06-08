using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_8.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfterTomorrowPage : ContentPage
    {
        public AfterTomorrowPage()
        {
            InitializeComponent();

            Appearing += AfterTomorrowPage_Appearing;
        }

        private async void AfterTomorrowPage_Appearing(object sender, EventArgs e)
        {
            var forecast = await WeatherData.GetForecast();

            var todayRecords = forecast.Where(item => DateTimeOffset.FromUnixTimeSeconds(item.Dt).UtcDateTime.DayOfYear == DateTime.UtcNow.DayOfYear + 2).ToArray();
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