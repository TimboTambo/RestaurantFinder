using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using RestaurantFinder.Models;
using RestaurantFinder.Services;
using RestaurantFinder.Tests.Mocks;

namespace RestaurantFinder.Tests.Tests
{
    [TestFixture]
    public class RestaurantTests
    {
        private IRestaurantService _restaurantService;

        [SetUp]
        public void Init()
        {
            var apiService = new ApiServiceMock();
            _restaurantService = new RestaurantService(apiService);
        }

        [Test]
        public async Task GetAvailableRestaurantsInAreaReturnsExpectedNumberOfResults()
        {
            var testInput = "SE1";
            var expectedNumberOfResults = 4;
            var results = await _restaurantService.GetAvailableRestaurantsInArea(testInput);

            Assert.AreEqual(expectedNumberOfResults, results.Count());
        }

        [Test]
        public void GetAvailableRestaurantsReturnsOnlyAvailableResults()
        {
            var testInput = new List<RestaurantResult>
            {
                new RestaurantResult
                {
                    IsOpenNow = true
                },
                new RestaurantResult
                {
                    IsOpenNow = true
                },
                new RestaurantResult
                {
                    IsOpenNow = false
                },
                new RestaurantResult
                {
                    IsOpenNow = false
                }
            };
            var expectedNumberOfResults = 2;
            var results = _restaurantService.FilterAvailableRestaurants(testInput);

            Assert.AreEqual(expectedNumberOfResults, results.Count());
        }

        [Test]
        public void OrderRestaurantsForDisplayOrdersAsExpected()
        {
            var testInput = new List<RestaurantResult>
            {
                new RestaurantResult
                {
                    DefaultDisplayRank = 1,
                    IsSponsored = false,
                    Id = 1
                },
                new RestaurantResult
                {
                    DefaultDisplayRank = 5,
                    IsSponsored = true,
                    SponsoredPosition = 2,
                    Id = 2
                },
                new RestaurantResult
                {
                    DefaultDisplayRank = 100,
                    IsSponsored = true,
                    SponsoredPosition = 1,
                    Id = 3
                },
                new RestaurantResult
                {
                    DefaultDisplayRank = 20,
                    IsSponsored = false,
                    Id = 4
                }
            };
            var expectedOrder = new List<int> {3, 2, 1, 4};

            var results = _restaurantService.OrderRestaurantsForDisplay(testInput).ToList();

            for (var i = 0; i < expectedOrder.Count; i++)
            {
                Assert.AreEqual(expectedOrder[i], results[i].Id);
            }
        }
    }
}
