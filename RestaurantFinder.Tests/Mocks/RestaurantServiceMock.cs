using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantFinder.Models;
using RestaurantFinder.Services;

namespace RestaurantFinder.Tests.Mocks
{
    class RestaurantServiceMock : IRestaurantService
    {
        public Task<IEnumerable<RestaurantResult>> GetAvailableRestaurantsInArea(string searchTerm)
        {
            return Task.FromResult((IEnumerable<RestaurantResult>)new List <RestaurantResult>
            {
                new RestaurantResult
                {
                    Name = "Test1"
                }
            });
        }

        public IEnumerable<RestaurantResult> OrderRestaurantsForDisplay(IEnumerable<RestaurantResult> restaurants)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RestaurantResult> FilterAvailableRestaurants(IEnumerable<RestaurantResult> restaurants)
        {
            throw new NotImplementedException();
        }
    }
}
