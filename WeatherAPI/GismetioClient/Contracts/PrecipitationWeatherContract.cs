using common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Contracts
{
    public class PrecipitationWeatherContract
    {
        public PrecipitationType Type { get; set; }

        public PrecipitationIntensityType Intensity { get; set; }
    }
}
