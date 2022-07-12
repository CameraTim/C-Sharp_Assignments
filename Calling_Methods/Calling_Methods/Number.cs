using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public static class Number
    {
        // Setting each method as static so that the class doesn't need to be instantiated
        public static int Addition(int adding)
        {
            int userAdd = adding + 10;
            return userAdd;
        }

        public static int Subtraction(int subbing)
        {
            int userSub = subbing - 10;
            return userSub;
        }

        public static int Multiply(int multi)
        {
            int userMul = multi * 10;
            return userMul;
        }
    }
}
