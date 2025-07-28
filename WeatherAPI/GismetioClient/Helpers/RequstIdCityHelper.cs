using GismetioClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Helpers
{
    public class RequstIdCityHelper
    {
        public static RequstGismetioModel GetIdCityRequstModel(string city, string apiKey)
        {
            return new RequstGismetioModel 
            { 
                HeaderName = "X-Gismeteo-Token",
                HeaderValue = apiKey,
                httpMethod = HttpMethod.Get,
                RequstUrl = $"/v2/search/cities/?query={city}",
            };

        }
    }
}
