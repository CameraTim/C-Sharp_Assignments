using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the object for the Number class
            Number numObject = new Number();

            // Writing a number and calling the integer AddNum method
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int resultAdd = numObject.AddNum(num);

            // Writing a number and calling the decimal AddNum method
            Console.WriteLine("Enter a number with a decimal:");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            decimal resultDec = numObject.AddNum(dec);

            // Writing a number and calling the string AddNum method
            Console.WriteLine("Enter another number:");
            string strNum = Console.ReadLine();
            string resultStr = numObject.AddNum(strNum);
            Console.WriteLine(resultAdd + " and " + resultDec + " and " + resultStr);
            Console.ReadLine();
        }
    }
}
