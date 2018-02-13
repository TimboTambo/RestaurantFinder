using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantFinder.Models;

namespace RestaurantFinder.Services
{
    public interface IApiService
    {
        Task<IEnumerable<RestaurantResult>> GetRestaurantsInArea(string searchTerm);
    }
}
