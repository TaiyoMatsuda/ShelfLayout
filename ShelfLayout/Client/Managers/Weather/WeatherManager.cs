using ShelfLayout.Shared;
using System.Net.Http.Json;

namespace ShelfLayout.Client.Managers.Weather
{
    public class WeatherManager: IWeatherManager
    {
        private readonly HttpClient _httpClient;

        public WeatherManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
