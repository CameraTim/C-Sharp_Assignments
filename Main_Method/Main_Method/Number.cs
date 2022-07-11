using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Number
    {
        // Making each method public to be called by any other program
        // Setting the first AddNum as an integer and set to receive an integer
        public int AddNum(int num)
        {
            // Adding 10 and returning to the Main program
            num = num + 10;
            return num;
        }
        // Setting to decimal to be able to receive a decimal
        public decimal AddNum(decimal dec)
        {
            // Converting the decimal after its multiplied to integer to be returned as an integer
            int decNum = (int)(dec * 2);
            return decNum;
        }
        // Setting as string
        public string AddNum(string str)
        {
            // Using try/catch in case user entry is not a number
            try
            {
                int strCon = Convert.ToInt32(str);
                strCon = strCon * 5;
                // Returning as a string as the expected value is a string
                return Convert.ToString(strCon);
            }
            // Runs catch if user entry is not a number
            catch (FormatException)
            {
                Console.WriteLine(str + " is not a number");
                return str;
            }
            
            

        }
    }
}
