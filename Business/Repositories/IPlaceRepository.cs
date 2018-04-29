using System.Collections.Generic;
using System.Threading.Tasks;
using CS.CoffePoint.Business.Entities;

namespace CS.CoffePoint.Business.Repositories
{
    public interface IPlaceRepository
    {
        Task<IList<PlaceEntity>> GetList();
    }
}
