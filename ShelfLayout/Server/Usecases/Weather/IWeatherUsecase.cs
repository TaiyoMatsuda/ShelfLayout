using ShelfLayout.Shared.Entities.Weather;

namespace ShelfLayout.Server.Usecases.Weather
{
    public interface IWeatherUsecase
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
