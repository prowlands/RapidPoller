using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using RapidPoller.Models;

namespace RapidPoller.Repository.Mongo
{
    public class RapidPollerPollRepository : IRapidPollerPollRepository
    {
        public ObjectId CreateNewPoll(Poll newPoll)
        {
            throw new NotImplementedException();
        }

        public bool DeletePoll(ObjectId pollId)
        {
            throw new NotImplementedException();
        }

        public bool DeletePollAnswer(ObjectId answerId)
        {
            throw new NotImplementedException();
        }

        public List<Poll> GetAllPolls()
        {
            throw new NotImplementedException();
        }

        public List<Poll> GetAllPollsFoUser(ObjectId userId)
        {
            throw new NotImplementedException();
        }

        public Poll GetPollById(ObjectId pollId)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePollAnswerCount(ObjectId answerId, int answerCount)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePollField<T>(ObjectId pollId, string fieldName, T updatedField)
        {
            throw new NotImplementedException();
        }
    }
}
