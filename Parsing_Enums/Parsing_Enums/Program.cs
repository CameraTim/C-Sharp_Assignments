using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking for user entry and calling the method for entry
            Console.WriteLine("Enter current day of the week:");
            Entry();
        }

        // Entry method
        public static void Entry()
        {
            // Try/Catch block to ensure entry is a day of the week listed in the enum
            try
            {
                // Converting the user entry to the enum type, and checking if the entry is valid
                DOW day = (DOW)Enum.Parse(typeof(DOW), Console.ReadLine());
                Console.WriteLine("It is currently " + day);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter actual day of the week:");
                Entry();
            }
        }

        public enum DOW
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
