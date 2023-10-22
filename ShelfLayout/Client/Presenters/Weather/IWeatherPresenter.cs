using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Client.Presenters.Weather
{
    public interface IWeatherPresenter
    {
        IPropertyObservable<WeatherForecast[]?> Forecasts { get; }

        Task GetAllAsync();
    }
}
