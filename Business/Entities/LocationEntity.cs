
namespace CS.CoffePoint.Business.Entities
{
    public class LocationEntity
    {
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        public LocationEntity(decimal longitude, decimal latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
