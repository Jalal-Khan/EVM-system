using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Booth
    {
        private static int count;
        public int Id{get; private set;}
        List<Candidate> CandidateList = new List<Candidate>();
        List<Voter> VotersList = new List<Voter>();
        List<Vote> VotesList = new List<Vote>();

public Booth(){
    this.Id=++_Count;
}

        public void AddVoter()
        {
            Console.Write("Name : ");
            var name = Console.ReadLine();
            Console.Write("CNIC : ");
            var cnic = Console.ReadLine();

            Voter addVoter = new Voter(name, cnic);

            VotersList.Add(addVoter);
        }

        public void AddCandidate()
        {
            Console.Write("Name : ");
            var name = Console.ReadLine();
            Console.Write("Sign : ");
            var sign = Console.ReadLine();

            Candidate addCandidate = new Candidate(name, sign);

            CandidateList.Add(addCandidate);
        }

 

        private DateTime StartDatetime { get; set; }
        public void Start()
        {
            this.StartDatetime = DateTime.Now;
            //var startTime = DateTime.Now;
            Console.WriteLine(this.StartDatetime.ToLongDateString());
        }
        public void End()
        {
            var endTime = this.StartDatetime.AddHours(4);
            Console.WriteLine(endTime);
        }

        public void VoteCast()
        {
            Vote voteCast = new Vote();
            VotesList.Add(voteCast);
        }
        public void VoterMenu()
        {
            Console.WriteLine("***********VOTE CASTING PROCESS***************");
            for (int i = 0; i < CandidateList.Count; i++)
            {
                Console.WriteLine($"PRESS {i + 1} FOR \"CAST VOTE TO {CandidateList[i].Sign}\"");
            }

            Console.WriteLine("SHOW VOTES OF CANDIDATES");

        }


    }
}
