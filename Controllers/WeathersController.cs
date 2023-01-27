using AWeatherAPI.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AWeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        public WeathersController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetCurrentWeather(string city)
        {
            var weather = await _weatherService.GetCurrentWeather(city);
            if (weather is not null) return Ok(weather);
            return BadRequest(weather);
        }

        [HttpGet("{lat}/{lon}")]
        public async Task<IActionResult> GetCurrentWeather(string lat, string lon)
        {
            var weather = await _weatherService.GetCurrentWeather(lat, lon);
            if (weather is not null) return Ok(weather);
            return BadRequest(weather);
        }

        [HttpGet("forcast/{lat}/{lon}")]
        public async Task<IActionResult> GetFiveDayWeatherForcast(string lat, string lon)
        {
            var weather = await _weatherService.GetFiveDayWeatherForcast(lat, lon);
            if (weather is not null) return Ok(weather);
            return BadRequest(weather);
        }
    }
}
