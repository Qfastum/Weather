namespace WeatherAPI.Configurations
{
    public interface IAppSettings
    {
        string OpenWeatherApiKey { get; set; }

        string GismeteoApiKey { get; set; }
    }
}
