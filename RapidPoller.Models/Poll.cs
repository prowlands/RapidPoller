using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace RapidPoller.Models
{
    public class Poll
    {
        [BsonId]
        public ObjectId PollId { get; set; }
        public ObjectId PollOwnerId { get; set; }
        public string Question { get; set; }
        public List<PollAnswer> Answers { get; set; }
        public List<string> Comments { get; set; }
        public bool PublicPoll { get; set; }
        public bool CommentsAllowed { get; set; }
    }

    
}
