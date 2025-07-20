using WeatherAPI.Contracts;

namespace WeatherAPI.Services.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherContract> GetOpenWeatherAsync(string city);
    }
}
