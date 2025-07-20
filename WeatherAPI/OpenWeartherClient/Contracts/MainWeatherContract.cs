using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenWeartherClient.Contracts
{
    public class MainWeatherContract
    {
        public decimal Temp { get; set; }

        [JsonProperty("temp_min")]
        public decimal TempMin { get; set; }

        [JsonProperty("temp_max")]
        public decimal TempMax { get; set; }
    }
}
