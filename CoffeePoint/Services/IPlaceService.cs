using System.Collections.Generic;
using System.Threading.Tasks;
using CS.CoffeePoint.Models;

namespace CS.CoffeePoint.Services
{
    public interface IPlaceService
    {
        Task<IList<PlaceModel>> GetList();
    }
}
