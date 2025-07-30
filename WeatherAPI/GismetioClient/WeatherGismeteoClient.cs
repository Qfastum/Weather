
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

        public async Task<WeatherResponResponseContract> GetWeatherAsync(string city, string apiKey)
        {
            try
            {
                Console.WriteLine("-------------------------------GetWeatherAsync---------------------------------");
                Console.WriteLine($"Starting city ID: {city}");

                var requestModel = RequstGismeteoHelper.GetWeatherRequstModel(city, apiKey);
                Console.WriteLine($"Request model: {JsonConvert.SerializeObject(requestModel)}");

                var result = await SendRequstAsync<WeatherResponResponseContract>(requestModel);
                Console.WriteLine($"API response: {JsonConvert.SerializeObject(result)}");
                Console.WriteLine("-------------------------------GetWeatherAsync---------------------------------");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------------------------------GetWeatherAsync---------------------------------");
                Console.WriteLine($"Error in GetWeatherAsync: {ex}");
                Console.WriteLine("-------------------------------GetWeatherAsync---------------------------------");
                throw;
            }

        }

        public async Task<CitySearchContract> GetCityIdAsync(string city, string apiKey)
        {
            try
            {
                Console.WriteLine("-------------------------------GetCityIdAsync---------------------------------");
                Console.WriteLine($"Starting city ID lookup for: {city}");

                var requestModel = RequstGismeteoHelper.GetIdCityRequstModel(city, apiKey);
                Console.WriteLine($"Request model: {JsonConvert.SerializeObject(requestModel)}");

                var result = await SendRequstAsync<CitySearchContract>(requestModel);
                Console.WriteLine($"API response: {JsonConvert.SerializeObject(result)}");

                if (result?.Response?.Items?.FirstOrDefault()?.IdCity == 0)
                {
                    throw new Exception($"City {city} was not found or the API returned an invalid data format");
                }
                Console.WriteLine("-------------------------------GetCityIdAsync---------------------------------");

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------------------------------GetCityIdAsync---------------------------------");
                Console.WriteLine($"Error in GetCityIdAsync: {ex}");
                Console.WriteLine("-------------------------------GetCityIdAsync---------------------------------");
                throw;
            }           
        }

        private async Task<T> SendRequstAsync<T>(RequstGismeteoModel model)
        {
            const string GismeteoTokenHeader = "X-Gismeteo-Token";
            var requestMessage = new HttpRequestMessage(model.httpMethod, model.RequstUrl);
            requestMessage.Headers.Add(GismeteoTokenHeader, model.ApiKey);

            Console.WriteLine($"Sending request to: {model.RequstUrl}");
            Console.WriteLine($"Headers: {string.Join(", ", requestMessage.Headers.Select(h => $"{h.Key}={string.Join(",", h.Value)}"))}");

            var responsMessage = await _httpClient.SendAsync(requestMessage);

            if (responsMessage.IsSuccessStatusCode)
            {
                var responsLine = await responsMessage.Content.ReadAsStringAsync();

                Console.WriteLine($"Response status: {responsMessage.StatusCode}");
                Console.WriteLine($"Responns body: {responsLine}");

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
