using Lab_8.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Lab_8
{
    public static class WeatherData
    {
        private const string APP_ID = "61e57c4c3feb8a84911fb14174e1d996";
        private static DataItem _dataNow;
        private static DataItem[] _forecast;

        private async static Task<Location> GetGpsDataAsync()
        {
            Location result;
            try
            {
                result = await Geolocation.GetLastKnownLocationAsync();
            }
            catch
            {
                result = new Location(53.9013, 27.5584);
            }
            if (result == null)
            {
                result = new Location(53.9013, 27.5584);
            }
            return result;
        }

        private async static Task<string> GetData(string request)
        {
            try
            {
                string rt;

                WebRequest req = WebRequest.Create(request);
                WebResponse response = await req.GetResponseAsync();
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                rt = reader.ReadToEnd();

                Console.WriteLine(rt);

                reader.Close();
                response.Close();

                return rt;
            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public async static Task<DataItem> GetTodayData()
        {
            if (_dataNow != null)
            {
                return _dataNow;
            }

            var coords = await GetGpsDataAsync();
            string req = $"https://api.openweathermap.org/data/2.5/weather?lat={coords.Latitude}&lon={coords.Longitude}&units=metric&appid={APP_ID}";
            string data = await GetData(req);
            DataItem item;
            try
            {
                
                item = JsonConvert.DeserializeObject<DataItem>(data);
            }
            catch
            {
                item = new DataItem();
            }
            _dataNow = item;
            RequestTodayCooldown();
            return item;
        }

        private async static void RequestTodayCooldown()
        {
            await Task.Delay(10000);
            _dataNow = null;
        }

        public async static Task<DataItem[]> GetForecast()
        {
            if (_forecast != null)
            {
                return _forecast;
            }

            var coords = await GetGpsDataAsync();
            string req = $"https://api.openweathermap.org/data/2.5/forecast?lat={coords.Latitude}&lon={coords.Longitude}&units=metric&appid={APP_ID}";
            string data = await GetData(req);
            ItemList items;
            try
            {

                items = JsonConvert.DeserializeObject<ItemList>(data);
            }
            catch
            {
                items = new ItemList();
            }
            _forecast = items.List;
            RequestForecastCooldown();
            return items.List;
        }

        private async static void RequestForecastCooldown()
        {
            await Task.Delay(10000);
            _forecast = null;
        }
    }
}
