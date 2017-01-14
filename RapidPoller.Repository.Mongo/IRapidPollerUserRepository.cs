using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidPoller.Models;
using System.Security.Cryptography;
using MongoDB.Bson;

namespace RapidPoller.Repository
{
    public interface IRapidPollerUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(ObjectId id);
        User GetUserByEmailAddress(string emailAddress);
        ObjectId CreateNewUser(User newUser);
        bool DeleteUser(ObjectId id);
        bool UpdateField<T>(ObjectId id, string fieldName, T updatedField);
    }
}
