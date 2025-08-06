using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Contracts
{
    public class DateWeatherContract
    {
        [JsonProperty("local")]
        public DateTime date { get; set; }
    }
}
