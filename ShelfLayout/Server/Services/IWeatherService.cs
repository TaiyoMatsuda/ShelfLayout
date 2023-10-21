using ShelfLayout.Shared.Entities.Weather;

namespace ShelfLayout.Server.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
