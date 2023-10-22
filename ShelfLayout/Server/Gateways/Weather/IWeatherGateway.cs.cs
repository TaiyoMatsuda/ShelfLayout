using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Server.Gateways.Weather
{
    public interface IWeatherGateway
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
