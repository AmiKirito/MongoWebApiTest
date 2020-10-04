using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoWebApi.Models;

namespace MongoWebApi.Data
{
    public class GamestoreContext
    {
        private readonly IMongoDatabase _database = null;

        public GamestoreContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);

            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoCollection<Game> Games
        {
            get
            {
                return _database.GetCollection<Game>("games");
            }
        }
    }
}
