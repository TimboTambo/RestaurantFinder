using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using RestaurantFinder.Services;

namespace RestaurantFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantService _restaurantFinderService;

        public HomeController(IRestaurantService restaurantFinderService)
        {
            _restaurantFinderService = restaurantFinderService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<string> GetAvailableRestaurantsInArea(string searchTerm)
        {
            var results = await _restaurantFinderService.GetAvailableRestaurantsInArea(searchTerm);
            return JsonConvert.SerializeObject(results);
        }
    }
}