using GismetioClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Helpers
{
    public static class RequstWeatherHelper
    {
        public static RequstGismetioModel GetWeatherRequstModel(string city, string apiKey)
        {
            return new RequstGismetioModel 
            {
                RequstUrl= $"/v2/weather/current/{city}",
                httpMethod = HttpMethod.Get,
                ApiKey = apiKey,
            };

        }
    }
}
