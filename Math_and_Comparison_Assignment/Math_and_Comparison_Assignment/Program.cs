using System;
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        
        // Capture Person 1 and 2's rate and hours
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?:");
        string per1Rate = Console.ReadLine();
        Console.WriteLine("Hours worked per week?:");
        string per1Hours = Console.ReadLine();
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?:");
        string per2Rate = Console.ReadLine();
        Console.WriteLine("Hours worked per week?:");
        string per2Hours = Console.ReadLine();
        Console.WriteLine("Annual salary of Person 1:");

        // Converting each user input to integers
        int per1RateInt = Convert.ToInt32(per1Rate);
        int per1HoursInt = Convert.ToInt32(per1Hours);
        int per2RateInt = Convert.ToInt32(per2Rate);
        int per2HoursInt = Convert.ToInt32(per2Hours);

        // Multiply rate and hours by 52 to achieve annual income
        int per1Salary = per1RateInt * per1HoursInt * 52;
        int per2Salary = per2RateInt * per2HoursInt * 52;

        // Compare both salaries to determine who makes the most dough
        bool personComp = per1Salary > per2Salary;
        Console.WriteLine(per1Salary);
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(per2Salary);
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(personComp);
        Console.ReadLine();
    }
}
