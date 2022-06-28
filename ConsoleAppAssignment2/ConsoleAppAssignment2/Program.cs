using System;
class Program
    {
        static void Main()
        {
        // Creating user input
        Console.WriteLine("Enter a number:");
        string num1Entry = Console.ReadLine();
        // Convert the entry into an integer
        int num1Use = Convert.ToInt32(num1Entry);
        // Multiplying the integer by 50
        num1Use = num1Use * 50;
        Console.WriteLine("Your number times 50 is: " + num1Use);
        Console.WriteLine("Please type another number:");
        string num2Entry = Console.ReadLine();
        int num2Use = Convert.ToInt32(num2Entry);
        num2Use = num2Use + 25;
        Console.WriteLine("Adding 25 to your number results in: " + num2Use);
        Console.WriteLine("Please type another number:");
        string num3Entry = Console.ReadLine();
        // Converting to double to allow for decimals
        double num3Use = Convert.ToDouble(num3Entry);
        num3Use = num3Use / 12.5;
        Console.WriteLine("Your number divided by 12.5 is: " + num3Use);
        Console.WriteLine("Please type another number:");
        string num4Entry = Console.ReadLine();
        int num4Use = Convert.ToInt32(num4Entry);
        // Running a comparison variable to check if the input is higher than 50
        bool trueCheck;
        if (num4Use > 50)
        {
            trueCheck = true;
        }
        else
        {
            trueCheck = false;
        }
        Console.WriteLine(num4Use + " > 50 is " + trueCheck);
        Console.WriteLine("Please type another number:");
        string num5Entry = Console.ReadLine();
        int num5Use = Convert.ToInt32(num5Entry);
        // Using a modulus oprator to obtain remainder
        num5Use = num5Use % 7;
        Console.WriteLine("The remainder from your number is: " + num5Use);
        Console.ReadLine();
    }
}