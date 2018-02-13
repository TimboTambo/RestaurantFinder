using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantFinder.Models;

namespace RestaurantFinder.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IApiService _apiService;

        public RestaurantService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IEnumerable<RestaurantResult>> GetAvailableRestaurantsInArea(string searchTerm)
        {
            var restaurantsInArea = await _apiService.GetRestaurantsInArea(searchTerm);
            var availableRestaurantsInArea = FilterAvailableRestaurants(restaurantsInArea);
            return OrderRestaurantsForDisplay(availableRestaurantsInArea);
        }

        public IEnumerable<RestaurantResult> FilterAvailableRestaurants(IEnumerable<RestaurantResult> restaurants)
        {
            foreach (var restaurant in restaurants)
            {
                if (restaurant.IsOpenNow)
                {
                    yield return restaurant;
                }
            }
        }

        public IEnumerable<RestaurantResult> OrderRestaurantsForDisplay(IEnumerable<RestaurantResult> restaurants)
        {
            var sponsoredRestaurants = new List<RestaurantResult>();
            var otherRestaurants = new List<RestaurantResult>();

            foreach (var restaurant in restaurants)
            {
                if (restaurant.IsSponsored)
                {
                    sponsoredRestaurants.Add(restaurant);
                }
                else
                {
                    otherRestaurants.Add(restaurant);
                }
            }

            foreach (var restaurant in sponsoredRestaurants.OrderBy(x => x.SponsoredPosition))
            {
                yield return restaurant;
            }

            foreach (var restaurant in otherRestaurants.OrderBy(x => x.DefaultDisplayRank))
            {
                yield return restaurant;
            }
        }
    }
}