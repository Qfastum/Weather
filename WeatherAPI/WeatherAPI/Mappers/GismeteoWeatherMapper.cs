using WeatherAPI.Contracts;

namespace WeatherAPI.Mappers
{
    public static class GismeteoWeatherMapper
    {

        public static GismeteoWeatherContract Map(GismetioClient.Contracts.WeatherResponseContract response)
        {
            return new GismeteoWeatherContract
            {
                LocalDate = response.Date.LocalDate,
                AirDegreesOfHeat = response.Temperature.Air.DegreesOfHeat,
                ComfortDegreesOfHeat = response.Temperature.Comfort.DegreesOfHeat,
                DescriptionFull = response.Description.Full,
                HumidityPrecent = response.Humidity.Precent,
                AtmosphericPressure = response.Pressure.AtmosphericPressure,
                CloudinessPrecent = response.Cloudiness.Precent,
                CloudinessType = response.Cloudiness.Type,
                PrecipitationType = response.Precipitation.Type,
                PrecipitationIntensity =response.Precipitation.Intensity,
                WindDirectionType = response.Wind.Direction.DirectionType,
                WindSpeed = response.Wind.Speed.WindSpeed,
            };
        }
    }
}
