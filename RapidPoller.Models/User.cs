using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RapidPoller.Models
{
    public class User
    {
        [BsonId]
        public ObjectId UserId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
