using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Number
    {
        // Setting a default value on the second argument making it optional
        public int AddNum(int num1, int num2 = 9)
        {
            int num3 = num1 * num2;
            return num3;
        }
    }
}
