using ShelfLayout.Shared.Entities.View.Weather;
using System.Net.Http.Json;

namespace ShelfLayout.Client.Gateway.Weather
{
    public class WeatherGateway : IWeatherGateway
    {
        private readonly HttpClient _httpClient;

        public WeatherGateway(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
