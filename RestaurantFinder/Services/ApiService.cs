using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestaurantFinder.Models;

namespace RestaurantFinder.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<RestaurantResult>> GetRestaurantsInArea(string searchTerm)
        {
            var url = $"https://public.je-apis.com/restaurants?q={searchTerm}";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode || response.Content == null)
            {
                return new List<RestaurantResult>();
            }

            var stringResult = await response.Content.ReadAsStringAsync();
            var deserializedResult = JsonConvert.DeserializeObject<RestaurantCollectionResult>(stringResult);
            return deserializedResult.Restaurants;
        }
    }
}