using WeatherAPI.Contracts;

namespace WeatherAPI.Mappers
{
    public static class GismeteoWeatherMapper
    {

        public static GismeteoWeatherContract Map(GismetioClient.Contracts.WeatherResponResponseContract response)
        {

            var OpenResponse = response.Response;

            return new GismeteoWeatherContract
            {
                LocalDate = OpenResponse.Date.LocalDate,
                AirDegreesOfHeat = OpenResponse.Temperature.Air.DegreesOfHeat,
                ComfortDegreesOfHeat = OpenResponse.Temperature.Comfort.DegreesOfHeat,
                DescriptionFull = OpenResponse.Description.Full,
                HumidityPrecent = OpenResponse.Humidity.Precent,
                AtmosphericPressure = OpenResponse.Pressure.AtmosphericPressure,
                CloudinessPrecent = OpenResponse.Cloudiness.Precent,
                CloudinessType = OpenResponse.Cloudiness.Type,
                PrecipitationType = OpenResponse.Precipitation.Type,
                PrecipitationIntensity =OpenResponse.Precipitation.Intensity,
                WindDirectionType = OpenResponse.Wind.Direction.DirectionType,
                WindSpeed = OpenResponse.Wind.Speed.WindSpeed,
            };
        }
    }
}
