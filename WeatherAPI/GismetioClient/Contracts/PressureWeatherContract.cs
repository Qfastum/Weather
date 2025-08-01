using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Contracts
{
    public class PressureWeatherContract
    {
        [JsonProperty("mm_hg_atm")]
        public int AtmosphericPressure { get; set; }
    }
}
