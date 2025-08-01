using GismetioClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Services;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        private readonly IGismeteoWeatherService _gismeteoWeatherService;

        public WeatherController(IWeatherService weatherService, IGismeteoWeatherService gismeteoWeatherService)
        {
            _weatherService = weatherService;
            _gismeteoWeatherService = gismeteoWeatherService;
        }

        [HttpGet]
        [Route("get-open-weather")]
        public async Task<IActionResult> GetOpenWeatherByCity(string city) 
        {
            try
            {
                var result = await _weatherService.GetOpenWeatherAsync(city);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("get-gismetio-weather")]
        public async Task<IActionResult> GetGismetioWeatherByCity(string city)
        {
            try
            {
                var resalt = await _gismeteoWeatherService.GetGismeteoAsync(city);

                return Ok(resalt);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }
    }
}
