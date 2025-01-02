using MongoDB.Bson;
using MYYouTubeBootCamp601.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYYouTubeBootCamp601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new DatabaseConnectionString();
            var customerCollection = connection.GetCustomersCollection();

            var document = new BsonDocument
            {
                { "Name", customer.Name },
                { "City", customer.City },
                { "Balance", customer.Balance },
                { "ShoppingCount", customer.ShoppingCount }
            };

            customerCollection.InsertOne(document);
        }
        public void UpdateCustomer()
        {
            Console.WriteLine("Customer Updated");
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("Customer Deleted");
        }
        public void GetCustomer()
        {
            Console.WriteLine("Customer Retrieved");
        }
    }
}
