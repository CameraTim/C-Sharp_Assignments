using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating list
        List<int> numList = new List<int> { 12, 20, 24, 30, 50 };
        // Running a try/catch in case user entry is not valid
        try
        {
            Console.WriteLine("Write a number to divide numbers by:");
            int entry = Convert.ToInt32(Console.ReadLine());
            // Iterating through the list of numbers to divide each of them by the number entered
            foreach (int numbers in numList)
            {
                Console.WriteLine(numbers / entry);
            }
            Console.ReadLine();
        }
        // Displays if user enters a 0
        // "disp" will include the system error message
        catch (DivideByZeroException disp)
        {
            Console.WriteLine(disp + "\nNumbers cannot be divided by 0.");
        }
        // Displays when user enters a non-number
        catch (FormatException disp)
        {
            Console.WriteLine(disp + "\nEntry needs to be a number.");
        }
        Console.ReadLine();
        
    }
}

