using MongoDB.Bson;
using RapidPoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidPoller.Repository.Mongo
{
    public interface IRapidPollerPollRepository
    {
        List<Poll> GetAllPolls();
        List<Poll> GetAllPollsFoUser(ObjectId userId);
        Poll GetPollById(ObjectId pollId);
        ObjectId CreateNewPoll(Poll newPoll);
        bool DeletePoll(ObjectId pollId);
        bool UpdatePollField<T>(ObjectId pollId, string fieldName, T updatedField);
        bool UpdatePollAnswerCount(ObjectId answerId, int answerCount);
        bool DeletePollAnswer(ObjectId answerId);
    }
}
