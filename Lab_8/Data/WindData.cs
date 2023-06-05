using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8.Data
{
    [Serializable]
    public struct WindData
    {
        [JsonProperty("speed")]
        public float speed;
        [JsonProperty("deg")]
        public float deg;
        [JsonProperty("gust")]
        public float gust;
    }
}
