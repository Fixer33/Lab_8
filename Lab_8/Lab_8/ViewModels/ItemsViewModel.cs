using Lab_8.Models;
using Lab_8.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab_8.ViewModels
{
    public class TomorrowForecastViewModel : BaseViewModel
    {
        public TomorrowForecastViewModel()
        {
            Title = "Browse";
        }


        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}