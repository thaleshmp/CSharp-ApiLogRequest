using LogRequestApi.MongoDB.Entities;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace LogRequestApi.MongoDB.Repositories
{
    public class ApiLogRepository : BaseRepository
    {
        private IMongoCollection<ApiLog> _collection;

        public ApiLogRepository() : base()
        {
            _collection = _database.GetCollection<ApiLog>("apilogcollection");
        }

        public async Task CreateLog(ApiLog log)
        {
            await _collection.InsertOneAsync(log);
        }
    }
}
