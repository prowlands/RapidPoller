using MongoDB.Driver;
using RapidPoller.Models;
using RapidPoller.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidPoller
{
    class Program
    {
        private static IRapidPollerUserRepository _userRepository;

        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _userRepository = new RapidPollerUserRepository(client.GetDatabase("RapidPoller"));
            var id = _userRepository.CreateNewUser(new Models.User
            {
                EmailAddress = "test1@test.com",
                FirstName = "test",
                LastName = "lastName",
                Password = "password"
            });

            var userList = _userRepository.GetAllUsers();
            Console.WriteLine($"{userList.Count} users exist");

            var user = _userRepository.GetUserByEmailAddress("test1@test.com");
            var userId = user.UserId;
            Console.WriteLine($"UserName is {user.FirstName} {user.LastName}");
            _userRepository.UpdateField<string>(userId, nameof(User.FirstName), "Patrick");

            user = _userRepository.GetUserById(userId);
            Console.WriteLine($"UserName is {user.FirstName} {user.LastName}");

            _userRepository.DeleteUser(userId);

            userList = _userRepository.GetAllUsers();
            Console.WriteLine($"{userList.Count} users exist");

            Console.Read();
        }
    }
}
