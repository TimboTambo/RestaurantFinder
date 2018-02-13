using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantFinder.Models;
using RestaurantFinder.Services;

namespace RestaurantFinder.Tests.Mocks
{
    public class ApiServiceMock : IApiService
    {
        public Task<IEnumerable<RestaurantResult>> GetRestaurantsInArea(string searchTerm)
        {
            return Task.FromResult((IEnumerable<RestaurantResult>)new List<RestaurantResult>
            {
                new RestaurantResult
                {
                    Name = "Test Restaurant 1",
                    IsOpenNow = false,
                    IsSponsored = false
                },
                new RestaurantResult
                {
                    Name = "Test Restaurant 2",
                    IsOpenNow = true,
                    IsSponsored = true,
                    SponsoredPosition = 1,
                    DefaultDisplayRank = 100
                },
                new RestaurantResult
                {
                    Name = "Test Restaurant 3",
                    IsOpenNow = true,
                    IsSponsored = false,
                    SponsoredPosition = 1,
                    DefaultDisplayRank = 1
                },
                new RestaurantResult
                {
                    Name = "Test Restaurant 4",
                    IsOpenNow = true,
                    IsSponsored = false,
                    SponsoredPosition = 1,
                    DefaultDisplayRank = 2
                },
                new RestaurantResult
                {
                    Name = "Test Restaurant 5",
                    IsOpenNow = true,
                    IsSponsored = true,
                    SponsoredPosition = 2,
                    DefaultDisplayRank = 5
                },
                new RestaurantResult
                {
                    Name = "Test Restaurant 6",
                    IsOpenNow = false,
                    IsSponsored = true,
                    SponsoredPosition = 3,
                    DefaultDisplayRank = 26
                },
            });
        }
    }
}
