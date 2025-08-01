using GismetioClient;
using WeatherAPI.Configurations;
using WeatherAPI.Contracts;
using WeatherAPI.Mappers;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class GismeteoWaetherService : IGismeteoWeatherService
    {

        private readonly IWeatherGismeteoClient _weatherGismetioClient;

        private readonly IAppSettings _appSettings;

        public GismeteoWaetherService(IWeatherGismeteoClient weatherGismetioClient, IAppSettings appSettings)
        {
            _weatherGismetioClient = weatherGismetioClient;
            _appSettings = appSettings;
        }

        public async Task<GismeteoWeatherContract> GetGismeteoAsync(string city)
        {
            var CityId = await _weatherGismetioClient.GetCityIdAsync(city, _appSettings.GismeteoApiKey);

            var weather = await _weatherGismetioClient.GetWeatherAsync(CityId.Response.Items[0].IdCity.ToString(), _appSettings.GismeteoApiKey);

            return GismeteoWeatherMapper.Map(weather);
        }
    }
}
