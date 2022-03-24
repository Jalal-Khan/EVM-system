using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Vote
    {
        string CNIC;
        public Vote(string cnic)
        {
            CNIC = cnic;

            Candidate Csign = new Candidate("", "");
            string sign = Csign.Sign;
               
        }
    }
}
 