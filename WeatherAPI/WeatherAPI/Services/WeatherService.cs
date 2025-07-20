using OpenWeartherClient;
using WeatherAPI.Configurations;
using WeatherAPI.Contracts;
using WeatherAPI.Mapers;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherClient _weatherClient;
        private readonly IAppSettings _appSettings;

        public WeatherService(IWeatherClient weatherClient, IAppSettings appSettings)
        {
            _weatherClient = weatherClient;
            _appSettings=appSettings;
        }

        public async Task<WeatherContract> GetOpenWeatherAsync(string city)
        {
            var weather = await _weatherClient.GetWeatherAsync(city, _appSettings.OpenWeatherApiKey);

            return WeatherMapper.Map(weather);
        }

    }
}
