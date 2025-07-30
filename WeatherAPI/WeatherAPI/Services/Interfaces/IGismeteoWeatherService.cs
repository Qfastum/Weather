using WeatherAPI.Contracts;

namespace WeatherAPI.Services.Interfaces
{
    public interface IGismeteoWeatherService
    {
        Task<GismeteoWeatherContract> GetGismeteoAsync(string city);
    }
}
