using Microsoft.AspNetCore.Components;
using ShelfLayout.Client.Presenters.Weather;
using ShelfLayout.Shared.Entities;
using ShelfLayout.Shared.Entities.View.Weather;

namespace ShelfLayout.Client.Pages.Weather
{
    public partial class FetchData
    {
        private WeatherForecast[]? _forecasts;
        
        private DisposableList _disposables = new();

        [Inject]
        private IWeatherPresenter _presenter { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await _presenter.GetAllAsync();

            var disposable = _presenter.Forecasts.Subscribe((x) =>
            {
                _forecasts = x;
                StateHasChanged();
            });

            _disposables.Add(disposable);
        }

        public void Dispose()
        {
            _disposables.DisposeAll();
        }
    }
}
