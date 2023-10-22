using ShelfLayout.Server.Repositorys.Weather;
using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Server.Usecases.Weather
{
    public class WeatherUsecase : IWeatherUsecase
    {
        private readonly IWeatherRepository _gateway;

        public WeatherUsecase(IWeatherRepository gateway)
        {
            _gateway = gateway;
        }

        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return _gateway.GetWeatherForecasts();
        }
    }
}
