using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantFinder.Tests.Mocks
{
    public class ApiMessageHandlerMock : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"Restaurants\":[{\"Badges\":[],\"Score\":10.2344284,\"DriveDistance\":1.8,\"DriveInfoCalculated\":true,\"NewnessDate\":\"2017-10-24T14:39:43.807Z\",\"DeliveryMenuId\":260794,\"DeliveryOpeningTime\":\"2018-02-11T12:00:00Z\",\"DeliveryCost\":2.0,\"MinimumDeliveryValue\":0.0,\"DeliveryTimeMinutes\":null,\"DeliveryWorkingTimeMinutes\":45,\"OpeningTime\":\"/Date(1518523200000+0000)/\",\"OpeningTimeIso\":\"2018-02-13T12:00:00Z\",\"SendsOnItsWayNotifications\":false,\"RatingAverage\":5.41,\"Latitude\":52.403383,\"Longitude\":-0.726297,\"Tags\":[],\"ScoreMetadata\":{},\"Id\":72596,\"Name\":\"MuMu - Kettering\",\"Address\":\"42 Rockingham Road\",\"Postcode\":\"NN16 8JS\",\"City\":\"Kettering\",\"CuisineTypes\":[{\"Id\":78,\"Name\":\"Burgers\",\"SeoName\":\"burgers\"},{\"Id\":82,\"Name\":\"Pizza\",\"SeoName\":\"pizza\"}],\"Url\":\"\",\"IsOpenNow\":true,\"IsPremier\":false,\"IsSponsored\":true,\"IsTemporaryBoost\":false,\"SponsoredPosition\":0,\"IsNew\":false,\"IsTemporarilyOffline\":false,\"ReasonWhyTemporarilyOffline\":\"\",\"UniqueName\":\"mumu---kettering-weekley\",\"IsCloseBy\":false,\"IsHalal\":false,\"IsTestRestaurant\":false,\"DefaultDisplayRank\":0,\"IsOpenNowForDelivery\":true,\"IsOpenNowForCollection\":true,\"RatingStars\":5.5,\"Logo\":[{\"StandardResolutionURL\":\"http://d30v2pzvrfyzpo.cloudfront.net/uk/images/restaurants/72596.gif\"}],\"Deals\":[],\"NumberOfRatings\":103},{\"Badges\":[],\"Score\":13.9524612,\"DriveDistance\":1.8,\"DriveInfoCalculated\":true,\"NewnessDate\":\"2016-11-08T14:16:33Z\",\"DeliveryMenuId\":230775,\"DeliveryOpeningTime\":\"2018-02-11T12:00:00Z\",\"DeliveryCost\":2.0,\"MinimumDeliveryValue\":12.0,\"DeliveryTimeMinutes\":null,\"DeliveryWorkingTimeMinutes\":45,\"OpeningTime\":\"/Date(1518436800000+0000)/\",\"OpeningTimeIso\":\"2018-02-12T12:00:00Z\",\"SendsOnItsWayNotifications\":false,\"RatingAverage\":5.2,\"Latitude\":52.405735,\"Longitude\":-0.713983,\"Tags\":[],\"ScoreMetadata\":{},\"Id\":65019,\"Name\":\"Pizza Time\",\"Address\":\"113 Avondale Road\",\"Postcode\":\"NN16 8PL\",\"City\":\"Kettering\",\"CuisineTypes\":[{\"Id\":27,\"Name\":\"Italian\",\"SeoName\":\"italian\"},{\"Id\":82,\"Name\":\"Pizza\",\"SeoName\":\"pizza\"}],\"Url\":\"\",\"IsOpenNow\":true,\"IsPremier\":false,\"IsSponsored\":false,\"IsTemporaryBoost\":false,\"SponsoredPosition\":0,\"IsNew\":false,\"IsTemporarilyOffline\":false,\"ReasonWhyTemporarilyOffline\":\"\",\"UniqueName\":\"pizza-time-weekley\",\"IsCloseBy\":false,\"IsHalal\":false,\"IsTestRestaurant\":false,\"DefaultDisplayRank\":1,\"IsOpenNowForDelivery\":true,\"IsOpenNowForCollection\":true,\"RatingStars\":5.0,\"Logo\":[{\"StandardResolutionURL\":\"http://d30v2pzvrfyzpo.cloudfront.net/uk/images/restaurants/65019.gif\"}],\"Deals\":[],\"NumberOfRatings\":154}]}")
            });
        }
    }
}
