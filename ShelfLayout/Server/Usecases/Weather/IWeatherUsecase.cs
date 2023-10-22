using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Server.Usecases.Weather
{
    public interface IWeatherUsecase
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
