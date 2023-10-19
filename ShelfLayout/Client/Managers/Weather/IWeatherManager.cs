using ShelfLayout.Shared;

namespace ShelfLayout.Client.Managers.Weather
{
    public interface IWeatherManager
    {
        Task<WeatherForecast[]> GetAllAsync();
    }
}
