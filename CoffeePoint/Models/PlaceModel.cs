
using System;

namespace CS.CoffeePoint.Models
{
    public class PlaceModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created{ get; set; }
        public Location Location{ get; set; }
    }
}
