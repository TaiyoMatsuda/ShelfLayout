using Microsoft.AspNetCore.Components;
using ShelfLayout.Client.Managers.Weather;
using ShelfLayout.Shared;

namespace ShelfLayout.Client.Pages.Weather
{
    public partial class FetchData
    {
        private WeatherForecast[]? forecasts;
        
        [Inject]
        private IWeatherManager _weatherManager { set; get; }
        
        protected override async Task OnInitializedAsync()
        {
            forecasts = await _weatherManager.GetAllAsync();
        }
    }
}
