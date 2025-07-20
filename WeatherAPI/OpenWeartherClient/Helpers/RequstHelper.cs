using OpenWeartherClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeartherClient.Helpers
{
    public static class RequstHelper
    {
        public static RequstModel GetWeatherRequstModel(string city, string apiKey)
        {
            return new RequstModel
            {
                RequstUrl = $"/data/2.5/weather?q={city}&appid={apiKey}",
                HttpMethod = HttpMethod.Get,             
            };
        }

    }
}
