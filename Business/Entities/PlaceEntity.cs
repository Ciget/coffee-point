using System;

namespace CS.CoffePoint.Business.Entities
{
    public class PlaceEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public LocationEntity Location { get; set; }
    }
}
