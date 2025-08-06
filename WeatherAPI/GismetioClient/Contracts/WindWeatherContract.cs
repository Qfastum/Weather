using common.Enums;
using Newtonsoft.Json;

namespace GismetioClient.Contracts
{
    public class WindWeatherContract
    {

        public DirectionWindContract Direction { get; set; }

        public SpeedWindContract Speed { get; set; }

    }
}
