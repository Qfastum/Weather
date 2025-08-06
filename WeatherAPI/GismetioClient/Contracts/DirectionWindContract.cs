using common.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Contracts
{
    public class DirectionWindContract
    {
        [JsonProperty("scale_8")]
        public ScaleWindType DirectionType { get; set; }
    }
}
