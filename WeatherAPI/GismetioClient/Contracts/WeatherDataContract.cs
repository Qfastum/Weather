namespace GismetioClient.Contracts
{
    public class WeatherDataContract
    {
        public DateWeatherContract Date { get; set; }

        public TemperatureWeatherContract Temperature {  get; set; }

        public DescriptionWeatherContract Description { get; set; }
    
        public HumidityWeatherContract Humidity { get; set; }

        public PressureWeatherContract Pressure { get; set; }

        public CloudinessWeatherContract Cloudiness { get; set; }

        public PrecipitationWeatherContract Precipitation { get; set; }

        public WindWeatherContract Wind { get; set; }
    }
}
