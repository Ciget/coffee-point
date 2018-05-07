using System;
using Newtonsoft.Json;

namespace CS.CoffePoint.Business.Entities
{
    public class PlaceEntity
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public LocationEntity Location { get; set; }
    }
}
