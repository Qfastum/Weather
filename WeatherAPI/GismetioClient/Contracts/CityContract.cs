using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GismetioClient.Contracts.CityContract;

namespace GismetioClient.Contracts
{
    public class CityContract
    {
        public ResponseData Response { get; set; }
    }

    public class ResponseData
    {
        public List<CytiIdItem> Items { get; set; }
    }

    public class CytiIdItem
    {
        [JsonProperty("id")]
        public int CityId { get; set; }
    }
}
