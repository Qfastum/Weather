using WeatherAPI.Contracts;
using GismetioClient.Contracts;

namespace WeatherAPI.Mappers
{
    public static class GismeteoWeatherMapper
    {

        public static GismeteoWeatherContract Map(WeatherDataResponseContract response)
        {

            var weather = response.WeatherData;

            return new GismeteoWeatherContract
            {
                Date = weather.Date.date,
                AirDegreesOfHeat = weather.Temperature.Air.DegreesOfHeat,
                ComfortDegreesOfHeat = weather.Temperature.Comfort.DegreesOfHeat,
                DescriptionFull = weather.Description.Full,
                HumidityPrecent = weather.Humidity.Percent,
                AtmosphericPressure = weather.Pressure.AtmosphericPressure,
                CloudinessPrecent = weather.Cloudiness.Percent,
                CloudinessType = weather.Cloudiness.Type,
                PrecipitationType = weather.Precipitation.Type,
                PrecipitationIntensity =weather.Precipitation.Intensity,
                WindDirectionType = weather.Wind.Direction.DirectionType,
                WindSpeed = weather.Wind.Speed.WindSpeed,
            };
        }
    }
}
