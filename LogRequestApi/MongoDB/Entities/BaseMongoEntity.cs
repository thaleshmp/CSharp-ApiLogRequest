using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LogRequestApi.MongoDB.Entities
{
    public class BaseMongoEntity
    {

        [BsonId]
        public ObjectId Id { get; set; }
    }
}