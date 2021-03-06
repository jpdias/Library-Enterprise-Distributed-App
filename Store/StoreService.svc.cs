﻿using System.Collections.Generic;
using System.Net;
using EnterpriseDistributedApplication;
using MongoDB.Driver;

namespace Store
{
    public class StoreService : IStoreService
    {
        public List<Book> GetBooks()
        {
            OrdersOps operation = new OrdersOps();
            List<Book> result = operation.GetAllBooks();

            return result;
           
        }
        
        public Book GetBook(string id)
        {
            MongoConnectionHandler dbConnection = new MongoConnectionHandler("store", "admin", "eda_store");
            var collection = dbConnection.dbClient.GetCollection<Book>("books");

            var task = collection.Find(book => book._id == id).ToListAsync();

            task.Wait();
            var results = task.Result;

            return results[0];
        }

        public HttpStatusCode AddBook(Book book)
        {
            MongoConnectionHandler dbConnection = new MongoConnectionHandler("store", "admin", "eda_store");
            var collection = dbConnection.dbClient.GetCollection<Book>("books");

            var task = collection.InsertOneAsync(book);

            task.Wait();
         
            return (HttpStatusCode) task.Status;
        }

        public bool Login(Customer customer)
        {
            Authentication authentication = new Authentication();

            return authentication.AuthenticateCustomer(customer);
        }

        public bool Register(Customer customer)
        {
            Authentication authentication = new Authentication();

            return authentication.CreateCustomer(customer);
        }

        public Customer GetCustomerByEmail(string email)
        {
            MongoConnectionHandler dbConnection = new MongoConnectionHandler("store", "admin", "eda_store");
            var collection = dbConnection.dbClient.GetCollection<Customer>("customers");

            var task = collection.Find(customer => customer.Email == email).ToListAsync();

            task.Wait();
            var results = task.Result;

            return results[0];
        }

        public Customer GetCustomer(string id)
        {
            MongoConnectionHandler dbConnection = new MongoConnectionHandler("store", "admin", "eda_store");
            var collection = dbConnection.dbClient.GetCollection<Customer>("customers");

            var task = collection.Find(customer => customer._id == id).ToListAsync();

            task.Wait();
            var results = task.Result;

            return results[0];
        }

        public List<Order> GetCustomerOrders(string id)
        {
            MongoConnectionHandler dbConnection = new MongoConnectionHandler("store", "admin", "eda_store");
            var collection = dbConnection.dbClient.GetCollection<Order>("orders");

            var task = collection.Find(order => order.Customer._id == id).ToListAsync();
            
            task.Wait();
            var results = task.Result;
            
            return results;
        }

        public Order NewOrder(Order order)
        {
            OrdersOps operation = new OrdersOps();
            Order result = operation.ProcessNewOrder(order);
            
            return result;
        }

        public HttpStatusCode PackageEnter(OrderBooks order)
        {
            OrdersOps operation = new OrdersOps();
            operation.ProcessNewPackage(order);
            return HttpStatusCode.OK;
        }
    }
}
