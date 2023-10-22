using ShelfLayout.Server.Gateways.Weather;
using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Server.Usecases.Weather
{
    public class WeatherUsecase : IWeatherUsecase
    {
        private readonly IWeatherGateway _gateway;

        public WeatherUsecase(IWeatherGateway gateway)
        {
            _gateway = gateway;
        }

        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return _gateway.GetWeatherForecasts();
        }
    }
}
