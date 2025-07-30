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
        Task<WeatherResponseContract> GetWeatherAsync(string city, string apiKey);

        Task<IdCityResponseContract> GetCityIdAsync(string city, string apiKey);
    }
}
