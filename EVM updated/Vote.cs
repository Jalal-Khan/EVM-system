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
        public Vote()
        {
            this.Id=++_Count;
               
        }
    }
}
 