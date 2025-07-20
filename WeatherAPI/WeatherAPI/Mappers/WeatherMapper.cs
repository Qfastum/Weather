using WeatherAPI.Contracts;

namespace WeatherAPI.Mapers
{
    public static class WeatherMapper
    {
        public static WeatherContract Map(OpenWeartherClient.Contracts.WeatherResponseContract response) 
        {
            //var weather = response.Weather.Where(x => x.Main != "Drizzle").FirstOrDefault(x => x.Main == "Sunny");
            var weather = response.Weather.FirstOrDefault();
            return new WeatherContract
            {
                Description = weather?.Description,
                Icon = weather?.Icon,
                WeatherConditions = weather?.Main,
                Temp = response.Main.Temp,
                TempMax = response.Main.TempMax,
                TempMin = response.Main.TempMin,
                WindSpeed = response.Wind.Speed,
            };
        }

    }
}
