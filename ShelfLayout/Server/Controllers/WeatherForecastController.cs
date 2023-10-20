using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Server.Services;
using ShelfLayout.Shared;

namespace ShelfLayout.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherService.GetWeatherForecasts();
        }
    }
}