namespace WeatherAPI.Configurations
{
    public class AppSettings : IAppSettings
    {
        public string OpenWeatherApiKey { get; set; }

        public AppSettings(IConfiguration configuration)
        {
            OpenWeatherApiKey = configuration.GetValue<string>(nameof(OpenWeatherApiKey));
        }
    }
}
