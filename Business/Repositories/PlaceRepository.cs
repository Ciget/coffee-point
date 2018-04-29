using System.Collections.Generic;
using System.Threading.Tasks;
using CS.CoffePoint.Business.Entities;

namespace CS.CoffePoint.Business.Repositories
{
    public class PlaceRepository : IPlaceRepository
    {
        public async Task<IList<PlaceEntity>> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}
