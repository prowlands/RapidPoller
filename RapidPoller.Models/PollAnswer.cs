using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace RapidPoller.Models
{
    public class PollAnswer
    {
        [BsonId]
        public ObjectId AnswerId { get; set; }
        public ObjectId PollId { get; set; }
        public string PollAnswers { get; set; }
        public int AnswerCount { get; set; }
    }
}
