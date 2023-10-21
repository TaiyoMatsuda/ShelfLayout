using ShelfLayout.Shared.Entities.Weather;

namespace ShelfLayout.Server.Gateways.Weather
{
    public interface IWeatherGateway
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
