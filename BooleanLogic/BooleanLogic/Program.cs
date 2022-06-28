using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        int ageNum = Convert.ToInt32(age);
        Console.WriteLine("Have you ever had a DUI?");
        string dui = Console.ReadLine();
        dui = dui.ToLower();
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
