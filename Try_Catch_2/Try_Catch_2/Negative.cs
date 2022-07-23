using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_2
{
    public class Negative : System.Exception
    {
        public Negative()
        {
        }

        public Negative(string message)
            : base(message)
        {
        }

        public Negative(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
