using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoWebApi.Models
{
    public class Game
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Name { get; set; }
    }
}
