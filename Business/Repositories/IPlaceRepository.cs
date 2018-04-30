using System.Collections.Generic;
using CS.CoffePoint.Business.Entities;

namespace CS.CoffePoint.Business.Repositories
{
    public interface IPlaceRepository
    {
        IList<PlaceEntity> GetList();
    }
}
