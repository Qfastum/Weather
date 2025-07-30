using WeatherAPI.Contracts;

namespace WeatherAPI.Mappers
{
    public static class IdCytiMapper
    {
        public static IdCytiContract Map(GismetioClient.Contracts.IdCityResponseContract response)
        {
            return new IdCytiContract
            {
                Id = response.Id,
            };
        }

    }
}
