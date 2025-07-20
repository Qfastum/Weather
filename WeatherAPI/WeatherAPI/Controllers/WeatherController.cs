using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
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
    }
}
