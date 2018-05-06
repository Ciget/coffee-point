using Microsoft.Extensions.Configuration;

namespace CS.CoffePoint.Business.Repositories
{
    public class BaseRepository
    {
        protected string Key = "qIgNekk25b3YgprzpXamxkxmVt4oGvIiI3ppABK3FzEoUZM44TixeF59z0Q9MXI9QNXGUTFAiaQmtLEmMKM6TA==";
        protected string Endpoint = "https://coffee-point.documents.azure.com:443/";
        protected readonly string DatabaseName;

        public BaseRepository(IConfiguration config)
        {
            Endpoint = config["Database:Endpoint"];
            Key = config["Database:Key"];
            DatabaseName = config["Database:Name"];
        }

        //protected static void Initialize()
        //{
        //    Client = new DocumentClient(new Uri(Endpoint), Key);
        //    CreateDatabaseIfNotExistsAsync().Wait();
        //    CreateCollectionIfNotExistsAsync().Wait();
        //}

        //private static async Task CreateDatabaseIfNotExistsAsync()
        //{
        //    try
        //    {
        //        await Client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId));
        //    }
        //    catch (DocumentClientException e)
        //    {
        //        if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
        //        {
        //            await Client.CreateDatabaseAsync(new Database { Id = DatabaseId });
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //}

        //private static async Task CreateCollectionIfNotExistsAsync(string collectionName)
        //{
        //    try
        //    {
        //        await Client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, collectionName));
        //    }
        //    catch (DocumentClientException e)
        //    {
        //        if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
        //        {
        //            await Client.CreateDocumentCollectionAsync(
        //                UriFactory.CreateDatabaseUri(DatabaseId),
        //                new DocumentCollection { Id = collectionName },
        //                new RequestOptions { OfferThroughput = 1000 });
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //}
    }
}
