using GismetioClient;
using WeatherAPI.Configurations;
using WeatherAPI.Contracts;
using WeatherAPI.Mappers;

namespace WeatherAPI.Services
{
    public class GismeteoWaetherServices
    {

        private readonly IWeatherGismeteoClient _weatherGismetioClient;

        private readonly IAppSettings _appSettings;

        public GismeteoWaetherServices(IWeatherGismeteoClient weatherGismetioClient, IAppSettings appSettings)
        {
            _weatherGismetioClient = weatherGismetioClient;
            _appSettings = appSettings;
        }

        public async Task<IdCytiContract> GetIdCytiAsync(string city)
        {
            var idCyti = await _weatherGismetioClient.GetCityIdAsync(city, _appSettings.GismeteoApiKey);

            return IdCytiMapper.Map(idCyti);
        }

        public async Task<GismeteoWeatherContract> GetGismeteoAsync(string city)
        {
            var weather = await _weatherGismetioClient.GetWeatherAsync(city, _appSettings.GismeteoApiKey);

            return GismeteoWeatherMapper.Map(weather);
        }
    }
}
