using Newtonsoft.Json;

namespace WeatherAPI.Contracts
{
    public class WeatherContract
    {
        public decimal Temp { get; set; }

        public decimal TempMin { get; set; }

        public decimal TempMax { get; set; }

        public double WindSpeed { get; set; }

        public string WeatherConditions { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }
    }
}
