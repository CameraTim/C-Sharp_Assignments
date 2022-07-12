using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to add, subtract, and multiply by:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            // Calling each method fromt the Number class passing the user input as the argument
            int numAdd = Number.Addition(userNum);
            int numSub = Number.Subtraction(userNum);
            int numMul = Number.Multiply(userNum);
            // Writing each returned value to the console with the math equasion
            Console.WriteLine("Adding 10 to " + userNum + " is: " + numAdd);
            Console.WriteLine("Subtracting 10 from " + userNum + " is: " + numSub);
            Console.WriteLine("Multiplying " + userNum + " by 10 is: " + numMul);
            Console.ReadLine();
        }
    }
}
