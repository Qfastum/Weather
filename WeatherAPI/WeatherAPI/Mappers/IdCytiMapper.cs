using WeatherAPI.Contracts;

namespace WeatherAPI.Mappers
{
    public static class IdCytiMapper
    {
        public static IdCytiContract Map(GismetioClient.Contracts.CitySearchContract response)
        {
            var firstId = response?.Response?.Items.FirstOrDefault()?.IdCity ?? 0;

            return new IdCytiContract
            {
                IdCyti = firstId.ToString(),
            };
        }

    }
}
