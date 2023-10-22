using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Client.Gateway.Weather
{
    public interface IWeatherGateway
    {
        Task<WeatherForecast[]> GetAllAsync();
    }
}
