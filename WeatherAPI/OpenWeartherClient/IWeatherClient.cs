using OpenWeartherClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeartherClient
{
    public interface IWeatherClient
    {
        Task<WeatherResponseContract> GetWeatherAsync(string city, string apiKey);
    }
}
