﻿using System;
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
            Console.WriteLine("Enter your CNIC");
            var cnic=Console.ReadLine();
            // check if voter is registered in this booth or not
            Voter voter=_FindVoterByCnic(cnic);
            while(voter==null){
                Console.WriteLine("Invalid CNIC or Voter is not enlisted in this Booth");
                cnic=Console.ReadLine();
                voter=_FindVoterByCnic(cnic);
            }
            // check if voter has casted vote or not
            if(_IsVoteCasted(voter.Id)){
                Console.WriteLine("You have already casted vote. You cannot cast another vote.");
                return;
            }

            Console.WriteLine("Enter your Candidate Sign");
            var sign=Console.ReadLine();
            Candidate candidate=_FindVoterByCnic(sign);
            while(voter==null){
                Console.WriteLine("Invalid Sign. Please select a valid sign");
                sign=Console.ReadLine();
                candidate=_FindVoterByCnic(sign);
            }

            Vote voteCast = new Vote(voter.Id, candidate.Id);
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


        // finds voter by CNIC in voters list
        private Voter _FindVoterByCnic(string cnic){
            Voter voter=null;
            for(int i=0;i<VotersList.Count;i++){
                if(VotersList[i].CNIC==cnic){
                    voter=VotersList[i];
                    break;
                }
            }
            return voter;
        }

        // finds candidate by Sign in candidates list
        private Voter _FindCandidateBySign(string sign){
            Candidate candidate=null;
            for(int i=0;i<CandidateList.Count;i++){
                if(CandidateList[i].Sign==sign){
                    candidate=CandidateList[i];
                    break;
                }
            }
            return candidate;
        }

        // checks whether vote is casted by voter or not
        private bool _IsVoteCasted(int id){
            for(int i=0;i<VotersList.Count;i++){
                if(VotersList[i].Id==id)return true;
            }
            return false;
        }
    }
}
