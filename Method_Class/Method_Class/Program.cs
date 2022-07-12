using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numOb = new Number();
            // First call passes in numbers and work in order
            numOb.Num(5, 10);
            // Second call passes in numbers with named parameters out of order as the method names will auto order the numbers
            numOb.Num(num2: 1, num1: 8);
            Console.ReadLine();
        }
    }
}
