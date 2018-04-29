using AutoMapper;
using CS.CoffeePoint.Models;
using CS.CoffePoint.Business.Entities;

namespace CS.CoffeePoint.Profiles
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<LocationEntity, Location>();
            CreateMap<PlaceEntity, PlaceModel>();
        }

    }
}
