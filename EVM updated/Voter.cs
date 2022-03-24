using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Voter
    {
        public string Name { get; set; }
        public string CNIC { get; set; }

        
        public Voter(string name, string cnic)
        {
            this.Name = name;
            this.CNIC = cnic;

        }
    }


}
