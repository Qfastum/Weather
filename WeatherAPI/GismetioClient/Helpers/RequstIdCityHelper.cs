using GismetioClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Helpers
{
    public static class RequstIdCityHelper
    {
        public static RequstGismetioModel GetIdCityRequstModel(string city, string apiKey)
        {
            return new RequstGismetioModel 
            {
                RequstUrl = $"/v2/search/cities/?query={city}",
                httpMethod = HttpMethod.Get,
                ApiKey = apiKey, 
            };

        }
    }
}
