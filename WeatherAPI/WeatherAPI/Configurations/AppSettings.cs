namespace WeatherAPI.Configurations
{
    public class AppSettings : IAppSettings
    {
        public string OpenWeatherApiKey { get; set; }
        
        public string GismeteoApiKey { get; set; }

        public AppSettings(IConfiguration configuration)
        {
            OpenWeatherApiKey = configuration.GetValue<string>(nameof(OpenWeatherApiKey));

            GismeteoApiKey = configuration.GetValue<string>(nameof(GismeteoApiKey));
        }
    }
}
