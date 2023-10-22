using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Server.Usecases.Weather;
using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherUsecase _weatherService;

        public WeatherForecastController(IWeatherUsecase weatherService)
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