using ShelfLayout.Shared.Entities.Response.Shelf;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShelfLayout.Client.Gateway.Shelf
{
    public class CabinetGateway: ICabinetGateway
    {
        private readonly HttpClient _httpClient;

        public CabinetGateway(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CabinetResponse>> GetAsync(int storeId, int cabinetId)
        {
            var res = await _httpClient.GetAsync($"api/shelf?storeId={storeId}&cabinetId={cabinetId}");
            if (res.IsSuccessStatusCode)
            {
                var jsonString = await res.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
                };
                
                return JsonSerializer.Deserialize<List<CabinetResponse>>(jsonString,options) ?? new List<CabinetResponse>();
            }
            else
            {
                throw new HttpRequestException($"Error fetching data: {res.StatusCode}");
            }
        }
    }
}
