using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8.Data
{
    [Serializable]
    public struct MainData
    {
        [JsonProperty("temp")]
        public float temp;
        [JsonProperty("feels_like")]
        public float feels_like;
        [JsonProperty("temp_min")]
        public float temp_min;
        [JsonProperty("temp_max")]
        public float temp_max;
        [JsonProperty("pressure")]
        public float pressure;
        [JsonProperty("humidity")]
        public float humidity;
    }
}
