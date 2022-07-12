using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Number
    {
        // void method so there's no return value
        public void num(int num1)
        {
            int num2 = num1 / 2;
            Console.WriteLine(num1 + " divided by 2 and rounded = " + num2);
        }
    }
    // Class and method are static so they don't require instantiation
    public static class StatNum
    {
        // numAdd methods have different argument requirements so they run only when the proper amount of arguments is called
        public static int numAdd(int numA)
        {
            numA = numA + 10;
            return numA;
        }
        public static int numAdd(int numA, int numB)
        {
            int numC = numA * numB;
            return numC;
        }
    }
}
