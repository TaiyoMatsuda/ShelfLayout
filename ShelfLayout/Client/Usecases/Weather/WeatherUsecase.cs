using ShelfLayout.Client.Gateway.Weather;
using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Client.Usecases.Weather
{
    public class WeatherUsecase : IWeatherUsecase
    {
        public IPropertyObservable<WeatherForecast[]?> Forecasts => _forecasts;
        private readonly PropertyObservable<WeatherForecast[]?> _forecasts;

        private readonly IWeatherGateway _gateway;

        public WeatherUsecase(IWeatherGateway gateway)
        {
            _gateway = gateway;

            _forecasts = new(null);
        }

        public async Task GetAllAsync()
        {
            var forecasts = await _gateway.GetAllAsync();
            _forecasts.Notify(forecasts);
        }
    }
}
