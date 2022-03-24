using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Candidate
    {
        private static int _Count;
        public int Id{get; private set;}
        public string Name { get; set; }
        public string Sign { get; set; }
        
        public Candidate(string name, string sign)
        {
            this.Name = name;
            this.Sign = sign;
            this.Id=++_Count;
        }
    }
}
