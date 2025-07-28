
using GismetioClient.Contracts;
using GismetioClient.Helpers;
using GismetioClient.Models;
using Newtonsoft.Json;

namespace GismetioClient
{
    public class WeatherGismetioClient
    {
        private readonly HttpClient _httpClient;

        public WeatherGismetioClient ()
        {
            _httpClient= new HttpClient
            {
                BaseAddress = new Uri($"https://api.gismeteo.net"),
            };
        }

        public async Task<WeatherResponseContract> GetWeatherAsync(string city, string apiKey)
        {
            var requstModel = RequstWeatherHelper.GetWeatherRequstModel(city, apiKey);
            var result = await SendRequstAsync<WeatherResponseContract>(requstModel);

            return result;
        }

        public async Task<IdCityResponseContract> GetCityIdAsync(string city, string apiKey)
        {
            var requstModel = RequstIdCityHelper.GetIdCityRequstModel(city, apiKey);
            var result = await SendRequstAsync<IdCityResponseContract>(requstModel);

            return result;
        }

        private async Task<T> SendRequstAsync<T>(RequstGismetioModel model)
        {
            
            var requstMessage = new HttpRequestMessage(model.httpMethod, model.RequstUrl);
            requstMessage.Headers.Add(model.HeaderName, model.HeaderValue);
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
