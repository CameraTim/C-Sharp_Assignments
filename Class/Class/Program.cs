using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the Number class
            Number numOb = new Number();
            Console.WriteLine("Enter a number:");
            int entry = Convert.ToInt32(Console.ReadLine());
            // Calling the num method from the numOb object
            numOb.num(entry);
            Console.WriteLine("Enter another number:");
            int entry1 = Convert.ToInt32(Console.ReadLine());
            // Running the static method inside the static StatNum class
            Console.WriteLine(entry + " + 10 = " + StatNum.numAdd(entry1));
            Console.WriteLine("Enter first number:");
            int entryA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int entryB = Convert.ToInt32(Console.ReadLine());
            // Calling the second numAdd method that requires two arguments
            int result = StatNum.numAdd(entryA, entryB);
            Console.WriteLine(entryA + " times " + entryB + " = " + result);
            Console.ReadLine();
        }
    }
}
