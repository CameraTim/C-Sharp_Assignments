using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();
        Console.WriteLine("Hello " + studentName + "! What course are you on?");
        string courseName = Console.ReadLine();
        Console.WriteLine("What page number of " + courseName + " are you on?");
        string pageNumber = Console.ReadLine();
        int pageNumInt = Convert.ToInt32(pageNumber);
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string helpInput = Console.ReadLine();
        bool helpChange = Convert.ToBoolean(helpInput);
        Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");
        string goodTimes = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hoursInput = Console.ReadLine();
        byte hoursStudy = Convert.ToByte(hoursInput);
        Console.WriteLine("Thank you for all the answers.  An Instructor will respond to this shortly.  Have a great day!");
        Console.ReadLine();


        }
    }






//Console.WriteLine("What is your name?");
//string yourName = Console.ReadLine();
//Console.WriteLine("Your name is: " + yourName);
//Console.ReadLine();

//Console.WriteLine("What is your favorite number?");
//string favoriteNumber = Console.ReadLine();
//int favNum = Convert.ToInt32(favoriteNumber);
//int total = favNum + 5;
//Console.WriteLine("Your favorite number is plus 5 is: " + total);
//Console.ReadLine();

//bool isStudying = false;
//byte hoursWorked = 42;
//sbyte currentTemp = -23;
//char questionMark = '\u2103';
//decimal moneyInBank = 100.5m;

//double heightInCentimeters = 211.1243145;
//float secondsLeft = 2.62f;
//short tempOnMars = -341;

//int currentage = 30;
//string yearsOld = currentage.ToString();
//bool isRaining = true;
//string rainingStatus = Convert.ToString(isRaining);