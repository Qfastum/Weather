using common.Enums;

namespace WeatherAPI.Contracts
{
    public class GismeteoWeatherContract
    {
        public string DataTime { get; set; }

        public float AirDegreesOfHeat { get; set; }

        public float ComfortDegreesOfHeat { get; set; }

        public string DescriptionFull { get; set; }

        public int HumidityPrecent { get; set; }

        public int AtmosphericPressure { get; set; }

        public int CloudinessPrecent { get; set; }

        public CludinessTypes CloudinessType { get; set; }

        public PrecipitationType PrecipitationType { get; set; }

        public PrecipitationIntensityType PrecipitationIntensity { get; set; }

        public ScaleWindType WindDirectionType { get; set; }

        public int WindSpeed { get; set; }
    }
}
