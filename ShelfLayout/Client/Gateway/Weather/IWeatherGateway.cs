using ShelfLayout.Shared.Entities.Weather;

namespace ShelfLayout.Client.Gateway.Weather
{
    public interface IWeatherGateway
    {
        Task<WeatherForecast[]> GetAllAsync();
    }
}
