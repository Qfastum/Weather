using GismetioClient;
using OpenWeartherClient;
using WeatherAPI.Configurations;
using WeatherAPI.Contracts;
using WeatherAPI.Mapers;
using WeatherAPI.Mappers;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherGismeteoClient _weatherGismetioClient;
        private readonly IWeatherClient _weatherClient;
        private readonly IAppSettings _appSettings;

        public WeatherService(IWeatherClient weatherClient, IAppSettings appSettings, IWeatherGismeteoClient weatherGismetioClient)
        {
            _weatherGismetioClient = weatherGismetioClient;
            _weatherClient = weatherClient;
            _appSettings=appSettings;
        }

        public async Task<WeatherContract> GetOpenWeatherAsync(string city)
        {
            var weather = await _weatherClient.GetWeatherAsync(city, _appSettings.OpenWeatherApiKey);

            return WeatherMapper.Map(weather);
        }

        public async Task<GismeteoWeatherContract> GetGismeteoWeatherAsync(string city)
        {
            var cityId = await _weatherGismetioClient.GetCityIdAsync(city, _appSettings.GismeteoApiKey);

            var id = cityId.Response.Items.FirstOrDefault();

            if (id == null)
            {
                return null;
            }

            var weather = await _weatherGismetioClient.GetWeatherAsync(id.CityId, _appSettings.GismeteoApiKey);

            return GismeteoWeatherMapper.Map(weather);
        }
    }
}
