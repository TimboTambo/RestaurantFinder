using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantFinder.Models;

namespace RestaurantFinder.Services
{
    public interface IRestaurantService
    {
        Task<IEnumerable<RestaurantResult>> GetAvailableRestaurantsInArea(string searchTerm);
        IEnumerable<RestaurantResult> OrderRestaurantsForDisplay(IEnumerable<RestaurantResult> restaurants);
        IEnumerable<RestaurantResult> FilterAvailableRestaurants(IEnumerable<RestaurantResult> restaurants);
    }
}
