using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string entry = Console.ReadLine();
            using (StreamWriter number = new StreamWriter(@"C:\Users\senek\logs\log.txt", true))
            {
                number.WriteLine(entry);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\senek\logs\log.txt"));
            Console.ReadLine();
        }
    }
}
