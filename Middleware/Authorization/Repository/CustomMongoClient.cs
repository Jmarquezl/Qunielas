using Authorization.Repository.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Clusters;

namespace Authorization.Repository
{
    public class CustomMongoClient : ICustomMongoClient
    {
        private readonly IMongoDatabase database;
        private readonly ILogger<CustomMongoClient> logger;
        private readonly ConnectionSettings settings;
        public CustomMongoClient(ILogger<CustomMongoClient> logger, IOptions<ConnectionSettings> settings)
        {
            this.logger = logger;
            this.settings = settings.Value;
            database = new MongoClient(MongoClientSettings.FromConnectionString(this.settings.URI)).GetDatabase(this.settings.DataBase);
        }
        public IMongoDatabase DataBase => database;
    }
}
