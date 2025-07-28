using GismetioClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Helpers
{
    public class RequstWeatherHelper
    {
        public static RequstWeatherModel GetWeatherRequstModel(string city, string apiKey)
        {
            return new RequstWeatherModel {
                RequstUrl= $"/v2/weather/current/{city}",
                httpMethod = HttpMethod.Get,
                HeaderName = "X-Gismeteo-Token",
                HeaderValue = apiKey,
            };

        }
    }
}
