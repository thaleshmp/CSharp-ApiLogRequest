using MongoDB.Driver;
using System.Configuration;

namespace LogRequestApi.MongoDB.Repositories
{
    public class BaseRepository
    {
        protected IMongoClient _client;
        protected IMongoDatabase _database;

        public BaseRepository()
        {
            _client = new MongoClient(ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString);
            _database = _client.GetDatabase("apilogrequest");
        }
    }
}
