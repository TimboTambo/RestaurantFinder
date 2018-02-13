using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using RestaurantFinder.Models;
using RestaurantFinder.Services;
using RestaurantFinder.Tests.Mocks;

namespace RestaurantFinder.Tests.Tests
{
    [TestFixture]
    public class ApiServiceTests
    {
        private HttpClient _httpClient;
        private IApiService _apiService;

        [SetUp]
        public void Init()
        {
            _httpClient = new HttpClient(new ApiMessageHandlerMock());
            _apiService = new ApiService(_httpClient);
        }

        [Test]
        public async Task GetRestaurantsInAreaReturnsExpectedNumberOfResults()
        {
            var testInput = "SE1";
            var expectedNumberOfResults = 2;
            var results = await _apiService.GetRestaurantsInArea(testInput);

            Assert.AreEqual(expectedNumberOfResults, results.Count());
        }

        [Test]
        public async Task GetRestaurantsInAreaMapsKeyFields()
        {
            var testInput = "SE1";
            var expectedResults = new List<RestaurantResult>
            {
                new RestaurantResult
                {
                    Name = "MuMu - Kettering",
                    CuisineTypes = new List<CuisineType>
                    {
                        new CuisineType {Name = "Burgers"},
                        new CuisineType {Name = "Pizza"}
                    },
                    RatingAverage = 5.41f
                },
                new RestaurantResult
                {
                    Name = "Pizza Time",
                    CuisineTypes = new List<CuisineType>
                    {
                        new CuisineType {Name = "Italian"},
                        new CuisineType {Name = "Pizza"}
                    },
                    RatingAverage = 5.2f
                }
            };

            var results = (await _apiService.GetRestaurantsInArea(testInput)).ToList();

            for (var i = 0; i < expectedResults.Count; i++)
            {
                Assert.AreEqual(expectedResults[i].Name, results[i].Name);
                Assert.AreEqual(expectedResults[i].RatingAverage, results[i].RatingAverage);
                for (var j = 0; j < expectedResults[i].CuisineTypes.Count; j++)
                {
                    Assert.AreEqual(expectedResults[i].CuisineTypes[j].Name, results[i].CuisineTypes[j].Name);
                }
            }
        }
    }
}
