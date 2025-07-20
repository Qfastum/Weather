using Newtonsoft.Json;
using OpenWeartherClient.Contracts;
using OpenWeartherClient.Helpers;
using OpenWeartherClient.Models;
using System.Threading.Tasks;

namespace OpenWeartherClient
{
    public class WeatherClient : IWeatherClient 
    {
        private readonly HttpClient _httpClient;

        public WeatherClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri($"https://api.openweathermap.org"),
            };
        }

        public async Task<WeatherResponseContract> GetWeatherAsync(string city, string apiKey)
        {
            var requestModel = RequstHelper.GetWeatherRequstModel(city, apiKey);
            var result = await SendRequstAsync<WeatherResponseContract>(requestModel);

            return result;
        }

        private async Task<T> SendRequstAsync<T>(RequstModel model) 
        {
            var requestMessage = new HttpRequestMessage(model.HttpMethod, model.RequstUrl);

            //requestMessage.Headers.Add("X-Gismeteo-Token",model.Key);
            var responseMessage = await _httpClient.SendAsync(requestMessage);

            //Обработка
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseLine = await responseMessage.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(responseLine);

                return result;
            }
            else
            {
                throw new Exception("");
            }

            
        }
    }
}
