using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Contracts
{
    public class WeatherDataResponseContract
    {
        [JsonProperty("response")]
        public WeatherDataContract WeatherData { get; set; }
    }
}
