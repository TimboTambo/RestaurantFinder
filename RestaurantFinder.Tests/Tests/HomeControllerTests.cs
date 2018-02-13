using System.Threading.Tasks;
using NUnit.Framework;
using RestaurantFinder.Controllers;
using RestaurantFinder.Tests.Mocks;

namespace RestaurantFinder.Tests.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _homeController;

        [SetUp]
        public void Init()
        {
            var restaurantService = new RestaurantServiceMock();
            _homeController = new HomeController(restaurantService);
        }

        [Test]
        public void Index()
        {
            var view = _homeController.Index();
            Assert.IsNotNull(view);
        }

        [Test]
        public void GetAvailableRestaurantsReturnsResults()
        {
            var testInput = "SE1";
            var results = _homeController.GetAvailableRestaurantsInArea(testInput);
            Assert.IsNotNull(results);
        }
    }
}
