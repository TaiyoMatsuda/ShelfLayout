using ShelfLayout.Client.Usecases.Weather;
using ShelfLayout.Shared.Entities;
using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.Weather;

namespace ShelfLayout.Client.Presenters.Weather
{
    public class WeatherPresenter : IWeatherPresenter
    {
        public IPropertyObservable<WeatherForecast[]?> Forecasts => _forcasts;
        private readonly PropertyObservable<WeatherForecast[]?> _forcasts;

        private readonly IWeatherUsecase _usecase;

        private readonly DisposableList _disposables = new();

        public WeatherPresenter(IWeatherUsecase usecase)
        {
            _usecase = usecase;

            _forcasts = new(null);

            var disposable = _usecase.Forecasts.Subscribe((num) =>
            {
                _forcasts.Notify(num);
            });

            _disposables.Add(disposable);
        }

        public async Task GetAllAsync()
        {
            await _usecase.GetAllAsync();
        }
    }
}
