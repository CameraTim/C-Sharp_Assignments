using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using DateTime.Now to pull current time
            Console.WriteLine(DateTime.Now + "\n\nPlease enter a number:");
            int entry = Convert.ToInt32(Console.ReadLine());
            // Using the .AddHours property to pass a value into to add to the hours of DateTime
            Console.WriteLine("In " + entry + " hours, it will be: " + DateTime.Now.AddHours(entry));
            Console.ReadLine();
        }
    }
}
