using System;
using System.Collections.Generic;
using Avocado.Entities;
using MongoDB.Driver;

namespace Avocado.Repositories
{
    public class MongoRepository : IRepository
    {
        private const string databaseName = "avocado";

        private const string collectionName = "users";


        private readonly IMongoCollection<User> usersCollection;

        public MongoRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            usersCollection = database.GetCollection<User>(collectionName);
        }

        public void CreateUser(User user)
        {
            usersCollection.InsertOne(user);
        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}