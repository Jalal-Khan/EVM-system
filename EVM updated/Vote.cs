using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Vote
    {
        private static int _Count;
        public int Id{get; private set;}
        public int VoterId {get; private set;}
        public int CandidateId {get; private set;}
        public DateTime CastTime {get; private set;}
        public Vote(int voterId, int candidateId)
        {
            this.Id=++_Count;
               VoterId=voterId;
               CandidateId=candidateId;
               CastTime=DateTime.UtcNow;
        }
    }
}
 