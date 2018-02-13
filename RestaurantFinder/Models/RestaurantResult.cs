using System.Collections.Generic;

namespace RestaurantFinder.Models
{
    public class RestaurantResult
    {
        public float Score { get; set; }
        public float? DriveDistance { get; set; }
        public double? DeliveryCost { get; set; }
        public float RatingAverage { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public List<CuisineType> CuisineTypes { get; set; }
        public bool IsOpenNow { get; set; }
        public bool IsSponsored { get; set; }
        public int SponsoredPosition { get; set; }
        public int DefaultDisplayRank { get; set; }
        public bool IsOpenNowForDelivery { get; set; }
        public bool IsOpenNowForCollection { get; set; }
        public float RatingStars { get; set; }
        public List<Logo> Logo { get; set; }
        public int NumberOfRatings { get; set; }
    }
}