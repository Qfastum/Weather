
using GismetioClient.Contracts;
using GismetioClient.Helpers;
using GismetioClient.Models;
using Newtonsoft.Json;

namespace GismetioClient
{
    public class WeatherGismeteoClient : IWeatherGismeteoClient
    {
        private readonly HttpClient _httpClient;

        public WeatherGismeteoClient ()
        {
            _httpClient= new HttpClient
            {
                BaseAddress = new Uri($"https://api.gismeteo.net"),
            };
        }

        public async Task<WeatherResponseContract> GetWeatherAsync(string city, string apiKey)
        {
            var requstModel = RequstGismeteoHelper.GetWeatherRequstModel(city, apiKey);
            var result = await SendRequstAsync<WeatherResponseContract>(requstModel);

            return result;
        }

        public async Task<IdCityResponseContract> GetCityIdAsync(string city, string apiKey)
        {
            var requstModel = RequstGismeteoHelper.GetIdCityRequstModel(city, apiKey);
            var result = await SendRequstAsync<IdCityResponseContract>(requstModel);

            return result;
        }

        private async Task<T> SendRequstAsync<T>(RequstGismeteoModel model)
        {
            const string GismeteoTokenHeader = "X-Gismeteo-Token";
            var requstMessage = new HttpRequestMessage(model.httpMethod, model.RequstUrl);
            requstMessage.Headers.Add(GismeteoTokenHeader, model.ApiKey);
            var responsMessage = await _httpClient.SendAsync(requstMessage);

            if (responsMessage.IsSuccessStatusCode)
            {
                var responsLine = await responsMessage.Content.ReadAsStringAsync();   
                var result = JsonConvert.DeserializeObject<T>(responsLine);

                return result;
            }
            else
            {
                throw new Exception("");
            }
        }
    }
}
