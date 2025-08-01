using WeatherAPI.Contracts;
using GismetioClient.Contracts;

namespace WeatherAPI.Mappers
{
    public static class GismeteoWeatherMapper
    {

        public static GismeteoWeatherContract Map(WeatherDataResponseContract response)
        {

            var OpenResponse = response.WeatherData;

            return new GismeteoWeatherContract
            {
                DataTime = OpenResponse.Date.DataTime,
                AirDegreesOfHeat = OpenResponse.Temperature.Air.DegreesOfHeat,
                ComfortDegreesOfHeat = OpenResponse.Temperature.Comfort.DegreesOfHeat,
                DescriptionFull = OpenResponse.Description.Full,
                HumidityPrecent = OpenResponse.Humidity.Percent,
                AtmosphericPressure = OpenResponse.Pressure.AtmosphericPressure,
                CloudinessPrecent = OpenResponse.Cloudiness.Percent,
                CloudinessType = OpenResponse.Cloudiness.Type,
                PrecipitationType = OpenResponse.Precipitation.Type,
                PrecipitationIntensity =OpenResponse.Precipitation.Intensity,
                WindDirectionType = OpenResponse.Wind.Direction.DirectionType,
                WindSpeed = OpenResponse.Wind.Speed.WindSpeed,
            };
        }
    }
}
