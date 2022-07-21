using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct Number
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 5.9M;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
