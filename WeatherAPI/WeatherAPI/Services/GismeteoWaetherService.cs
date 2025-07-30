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

        //public async Task<IdCytiContract> GetIdCytiAsync(string city)
        //{Created services and map for
        //    var idCyti = await _weatherGismetioClient.GetCityIdAsync(city, _appSettings.GismeteoApiKey);

        //    return IdCytiMapper.Map(idCyti);
        //}

        public async Task<GismeteoWeatherContract> GetGismeteoAsync(string city)
        {
            var idCity = await _weatherGismetioClient.GetCityIdAsync(city, _appSettings.GismeteoApiKey);
            var id = IdCytiMapper.Map(idCity);

            var weather = await _weatherGismetioClient.GetWeatherAsync(id.IdCyti, _appSettings.GismeteoApiKey);

            return GismeteoWeatherMapper.Map(weather);
        }
    }
}
