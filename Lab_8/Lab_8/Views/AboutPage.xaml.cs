using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace Lab_8.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Appearing += AboutPage_Appearing;
        }

        private async void AboutPage_Appearing(object sender, EventArgs e)
        {
            var data = await WeatherData.GetTodayData();
            weatherInfo.SetInfo(data);
        }
    }
}