using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the Number class
            Number numOb = new Number();
            // Running try/catch for any non-number input
            try
            {
                Console.WriteLine("Please enter a number:");
                int entry1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an additional number or leave blank and press enter:");
                // Keeping second entry as a string in case no input is entered
                string entry2str = Console.ReadLine();
                // Checks to see if the second entry was blank
                if (entry2str == "")
                {
                    // AddNum's second argument is optional, so if no input is given, the default value for the second argument is used
                    int result = numOb.AddNum(entry1);
                    Console.WriteLine(result);
                }
                else
                {
                    // If second input is used, both arguments are passed through
                    int entry2 = Convert.ToInt32(entry2str);
                    int result = numOb.AddNum(entry1, entry2);
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            }
            // Catch only runs on letter input or no input on first entry
            catch (FormatException)
            {
                Console.WriteLine("That was not a number silly goose.");
                Console.ReadLine();
            }
            
        }
    }
}
