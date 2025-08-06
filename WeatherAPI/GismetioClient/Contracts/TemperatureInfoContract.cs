using Newtonsoft.Json;

namespace GismetioClient.Contracts
{
    public class TemperatureInfoContract
    {
        [JsonProperty("C")]
        public float DegreesOfHeat { get; set; }
    }
}
