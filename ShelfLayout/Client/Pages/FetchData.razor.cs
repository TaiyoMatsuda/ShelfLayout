using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShelfLayout.Shared;

namespace ShelfLayout.Client.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
