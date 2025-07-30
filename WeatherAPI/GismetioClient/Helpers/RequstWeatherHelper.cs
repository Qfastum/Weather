using GismetioClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Helpers
{
    public static class RequstGismeteoHelper
    {
        public static RequstGismeteoModel GetWeatherRequstModel(string city, string apiKey)
        {
            return new RequstGismeteoModel 
            {
                RequstUrl= $"/v2/weather/current/{city}/",
                httpMethod = HttpMethod.Get,
                ApiKey = apiKey,
            };

        }

        public static RequstGismeteoModel GetIdCityRequstModel(string city, string apiKey)
        {
            return new RequstGismeteoModel
            {
                RequstUrl = $"/v2/search/cities/?query={city}",
                httpMethod = HttpMethod.Get,
                ApiKey = apiKey,
            };

        }
    }
}
