using MongoDB.Bson;
using MongoDB.Driver; // for Find()
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

        public void UpdateCustomer(Customer customer)
        {
            var connection = new DatabaseConnectionString();
            var customerCollection = connection.GetCustomersCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("Name", customer.Name)
                .Set("City", customer.City)
                .Set("Balance", customer.Balance)
                .Set("ShoppingCount", customer.ShoppingCount);

            customerCollection.UpdateOne(filter, updatedValue);
        }

        public void DeleteCustomer(string id)
        {
            var connection = new DatabaseConnectionString();
            var customerCollection = connection.GetCustomersCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }

        public Customer GetById(string id)
        {
            var connection = new DatabaseConnectionString();
            var customerCollection = connection.GetCustomersCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = customerCollection.Find(filter).FirstOrDefault();

            return new Customer
            {
                CustomerId = result["_id"].ToString(),
                Name = result["Name"].ToString(),
                City = result["City"].ToString(),
                Balance = decimal.Parse(result["Balance"].ToString()),
                ShoppingCount = int.Parse(result["ShoppingCount"].ToString())
            };
        }

        public List<Customer> GetAllCustomer()
        {
            var connection = new DatabaseConnectionString();
            var customerCollection = connection.GetCustomersCollection();

            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();

            //foreach (var customer in customers)
            //{
            //    customerList.Add(new Customer
            //    {
            //        CustomerId = customer.GetValue("_id").AsObjectId.ToString(),
            //        Name = customer.GetValue("Name").AsString,
            //        City = customer.GetValue("City").AsString,
            //        Balance = customer.GetValue("Balance").ToDecimal(),
            //        ShoppingCount = customer.GetValue("ShoppingCount").ToInt32()
            //    });
            //}

            foreach (var customer in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerId = customer["_id"].ToString(),
                    Name = customer["Name"].ToString(),
                    City = customer["City"].ToString(),
                    Balance = decimal.Parse(customer["Balance"].ToString()),
                    ShoppingCount = int.Parse(customer["ShoppingCount"].ToString())
                });
            }

            return customerList;
        }
    }
}
