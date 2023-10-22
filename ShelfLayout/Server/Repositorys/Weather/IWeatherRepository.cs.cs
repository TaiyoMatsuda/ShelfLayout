using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Server.Repositorys.Weather
{
    public interface IWeatherRepository
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
