using MongoDB.Driver;

namespace Authorization.Repository
{
    public interface ICustomMongoClient
    {
        public IMongoDatabase DataBase { get; }
    }
}
