using ShelfLayout.Shared;

namespace ShelfLayout.Server.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
