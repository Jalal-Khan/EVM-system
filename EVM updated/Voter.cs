using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVM_updated
{
    class Voter
    {
        private static int _Count;
        public int Id{get; private set;}
        public string Name { get; set; }
        public string CNIC { get; set; }

        
        public Voter(string name, string cnic)
        {
            this.Name = name;
            this.CNIC = cnic;
            this.Id=++_Count;
        }
    }


}
