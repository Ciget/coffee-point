using System;
using System.Collections.Generic;
using System.Linq;
using CS.CoffePoint.Business.Entities;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;

namespace CS.CoffePoint.Business.Repositories
{
    public class PlaceRepository : BaseRepository, IPlaceRepository
    {
        private const string CollectionName = "Places";
        private Uri _collectionUri;

        public IList<PlaceEntity> GetList()
        {
            _collectionUri = UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName);

            using (var client = new DocumentClient(new Uri(Endpoint), Key))
            {
                return client.CreateDocumentQuery<PlaceEntity>(_collectionUri, new FeedOptions {MaxItemCount = -1})
                    .Where(x=>x.Title.Length >10)
                    .ToList();
            }
        }

        public PlaceRepository(IConfiguration config) : base(config)
        {
        }
    }
}
