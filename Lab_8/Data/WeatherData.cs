using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8.Data
{
    [Serializable]
    public struct WeatherData
    {
        [JsonProperty("id")]
        public int id;
        [JsonProperty("main")]
        public string main;
        [JsonProperty("description")]
        public string description;
    }
}
