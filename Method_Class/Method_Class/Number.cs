using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    public class Number
    {
        // Method includes argument names so numbers passed through can be reordered
        public void Num(int num1, int num2)
        {
            num1 = num1 * 10;
            Console.WriteLine("The first number is " + num1);
            Console.WriteLine("The second number is " + num2);
        }
    }
}
