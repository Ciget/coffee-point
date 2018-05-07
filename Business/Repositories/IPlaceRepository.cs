using System.Collections.Generic;
using System.Threading.Tasks;
using CS.CoffePoint.Business.Entities;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace CS.CoffePoint.Business.Repositories
{
    public interface IPlaceRepository
    {
        IList<PlaceEntity> GetList();
        Task<ResourceResponse<Document>> Add(PlaceEntity record);
    }
}
