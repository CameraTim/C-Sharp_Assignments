using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age?");
        // Write age to variable and convert to number
        string age = Console.ReadLine();
        int ageNum = Convert.ToInt32(age);
        Console.WriteLine("Have you ever had a DUI?");
        string dui = Console.ReadLine();
        // Capturing result and converting to lower case to make if statement easier
        dui = dui.ToLower();
        // Initiating boolean variable for use in the if statement
        bool duiResult;
        if (dui == "yes" || dui == "true")
        {
            duiResult = true;
        }
        else
        {
            duiResult = false;
        }
        Console.WriteLine("How many speeding tickets do you have?");
        string way2fast = Console.ReadLine();
        int tickets = Convert.ToInt32(way2fast);
        Console.WriteLine("Qualified?");
        bool qualityPerson;
        // Using AND operator to confrim if all three results meet the requirements
        if (ageNum > 15 && duiResult == false && tickets <= 3)
        {
            qualityPerson = true;
        }
        else
        {
            qualityPerson = false;
        }
        Console.WriteLine(qualityPerson);
        Console.ReadLine();
    }
    }
