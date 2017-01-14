using System;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using RapidPoller.Models;
using MongoDB.Bson;

namespace RapidPoller.Repository
{
    public class RapidPollerUserRepository : IRapidPollerUserRepository
    {
        IMongoCollection<User> _collection;

        public RapidPollerUserRepository(IMongoCollection<User> collection)
        {
            _collection = collection;
        }

        public ObjectId CreateNewUser(User newUser)
        {
            _collection.InsertOne(newUser);
            return newUser.UserId;
        }

        public bool DeleteUser(ObjectId id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            var result = _collection.DeleteOne(filter);

            return result.DeletedCount > 0;
        }

        public List<User> GetAllUsers()
        {
            return _collection.Find<User>(new BsonDocument()).ToList<User>();
        }

        public User GetUserByEmailAddress(string emailAddress)
        {
            return _collection.Find<User>(new BsonDocument()).ToList<User>().First(x => x.EmailAddress == emailAddress); ;
        }

        public User GetUserById(ObjectId id)
        {
            return _collection.Find<User>(new BsonDocument()).ToList<User>().First(x => x.UserId == id);
        }

        public bool UpdateField<T>(ObjectId id, string fieldName, T updatedField)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            var update = Builders<User>.Update.Set(fieldName, updatedField);

            var result = _collection.UpdateOne(filter, update);

            if (result.IsModifiedCountAvailable)
            {
                return result.ModifiedCount > 0;
            }
            return false;
        }

        
    }
}
