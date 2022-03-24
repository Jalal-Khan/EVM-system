using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Candidate
    {
        public string Name { get; set; }
        public string Sign { get; set; }
        
        public Candidate(string name, string sign)
        {
            this.Name = name;
            this.Sign = sign;
        }
    }
}
