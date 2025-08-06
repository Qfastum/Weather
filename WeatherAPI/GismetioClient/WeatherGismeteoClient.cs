
using GismetioClient.Contracts;
using GismetioClient.Helpers;
using GismetioClient.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GismetioClient
{
    public class WeatherGismeteoClient : IWeatherGismeteoClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<WeatherGismeteoClient> _logger;

        public WeatherGismeteoClient (ILogger<WeatherGismeteoClient> logger)
        {
            _httpClient= new HttpClient
            {
                BaseAddress = new Uri($"https://api.gismeteo.net"),
            };

            _logger = logger;
        }

        public async Task<WeatherDataResponseContract> GetWeatherAsync(int cityId, string apiKey)
        {
            try
            {
                _logger.LogInformation($"Starting city ID: {cityId}");

                var requestModel = RequstGismeteoHelper.GetWeatherRequstModel(cityId, apiKey);
                _logger.LogDebug($"Request model: {JsonConvert.SerializeObject(requestModel)}");

                var result = await SendRequstAsync<WeatherDataResponseContract>(requestModel);
                _logger.LogDebug($"API response: {JsonConvert.SerializeObject(result)}");

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetWeatherAsync: {ex}");
                throw;
            }

        }

        public async Task<CityContract> GetCityIdAsync(string city, string apiKey)
        {
            try
            {
                _logger.LogInformation($"Starting city ID lookup for: {city}");

                var requestModel = RequstGismeteoHelper.GetIdCityRequstModel(city, apiKey);
                _logger.LogDebug($"Request model: {JsonConvert.SerializeObject(requestModel)}");

                var result = await SendRequstAsync<CityContract>(requestModel);
                _logger.LogDebug($"API response: {JsonConvert.SerializeObject(result)}");

                if (result?.Response?.Items?.FirstOrDefault()?.CityId == 0)
                {
                    var errorMessage = $"City {city} was not found or the API returned an invalid data format";
                    _logger.LogWarning(errorMessage);
                    throw new Exception(errorMessage);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetCityIdAsync: {ex}");
                throw;
            }           
        }

        private async Task<T> SendRequstAsync<T>(RequstGismeteoModel model)
        {
            const string GismeteoTokenHeader = "X-Gismeteo-Token";
            var requestMessage = new HttpRequestMessage(model.httpMethod, model.RequstUrl);
            requestMessage.Headers.Add(GismeteoTokenHeader, model.ApiKey);

            _logger.LogDebug($"Sending request to: {model.RequstUrl}");
            _logger.LogDebug($"Headers: {string.Join(", ", requestMessage.Headers.Select(h => $"{h.Key}={string.Join(",", h.Value)}"))}");

            var responseMessage = await _httpClient.SendAsync(requestMessage);

            if (responseMessage.IsSuccessStatusCode)
            {
                var responsLine = await responseMessage.Content.ReadAsStringAsync();

                _logger.LogDebug($"Response status: {responseMessage.StatusCode}");
                _logger.LogDebug($"Responns body: {responsLine}");

                var result = JsonConvert.DeserializeObject<T>(responsLine);
                return result;
            }
            else
            {
                var errorMessage = $"API request failed with status code: {responseMessage.StatusCode}";
                _logger.LogError(errorMessage);
                throw new Exception(errorMessage);
            }
        }
    }
}
