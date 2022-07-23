using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string var1 = "This is Constant";
            var var2 = "Implicit";
            Console.WriteLine(var1 + "\n" + var2 + "\n");

            Chained chained = new Chained();
            Console.WriteLine(chained.chain1 + "\n" + chained.chain2);
            Console.ReadLine();
            
        }
    }
}
