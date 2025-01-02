using MongoDB.Bson; // for BsonDocument
using MongoDB.Driver;
using MYYouTubeBootCamp601.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYYouTubeBootCamp601.Services
{
    public class DatabaseConnectionString
    {
        private IMongoDatabase _mongoDatabase;

        public DatabaseConnectionString()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("CSharpBootCamp601Database");
        }

        public IMongoCollection<BsonDocument> GetCustomersCollection()
        {
            return _mongoDatabase.GetCollection<BsonDocument>("Customers");
        }
    }
}
