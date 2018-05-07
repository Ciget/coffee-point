using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS.CoffePoint.Business.Entities;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;

namespace CS.CoffePoint.Business.Repositories
{
    public class PlaceRepository : BaseRepository, IPlaceRepository
    {
        private const string CollectionName = "Places";
        private readonly Uri _collectionUri;

        public IList<PlaceEntity> GetList()
        {
            using (var client = new DocumentClient(new Uri(Endpoint), Key))
            {
                return client.CreateDocumentQuery<PlaceEntity>(_collectionUri, new FeedOptions {MaxItemCount = -1})
                    .ToList();
            }
        }

        public async Task<ResourceResponse<Document>> Add(PlaceEntity record)
        {
            using (var client = new DocumentClient(new Uri(Endpoint), Key))
            {
                return await client.CreateDocumentAsync(_collectionUri, record);
            }
        }

        public PlaceRepository(IConfiguration config) : base(config)
        {
            _collectionUri = UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName);
        }
    }
}
