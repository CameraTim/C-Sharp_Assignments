using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Chained
    {
        public string chain1;
        public string chain2;

        public Chained() : this("Chained")
        {

        }
        public Chained(string chain1) : this(chain1, "Done be chained!")
        {

        }
        public Chained(string chain1, string chain2)
        {
            this.chain1 = chain1;
            this.chain2 = chain2;
        }
    }
}
