using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Contracts
{
    public class CitySearchContract
    {
        public ResponseData Response { get; set; }

        public class ResponseData
        {
            public List<IdCityItem> Items { get; set; }
        }

        public class IdCityItem
        {
            [JsonProperty("id")]
            public int IdCity { get; set; }
        }

    }
}
