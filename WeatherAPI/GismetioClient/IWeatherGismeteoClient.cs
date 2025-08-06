using GismetioClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient
{
    public interface IWeatherGismeteoClient
    {
        Task<WeatherDataResponseContract> GetWeatherAsync(int cityId, string apiKey);

        Task<CityContract> GetCityIdAsync(string city, string apiKey);
    }
}
