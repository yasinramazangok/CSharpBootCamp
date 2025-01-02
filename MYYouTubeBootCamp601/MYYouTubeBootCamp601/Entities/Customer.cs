using MongoDB.Bson; // for Bson.ObjectId
using MongoDB.Bson.Serialization.Attributes; // for BsonId
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYYouTubeBootCamp601.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public decimal Balance { get; set; }

        public int ShoppingCount { get; set; }
    }
}
