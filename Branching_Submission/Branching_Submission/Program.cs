using System;
class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the weight of your package:");
        // Grabbing the package weight and ensuring it's 50lbs or lower
        int packLbs = Convert.ToInt32(Console.ReadLine());
        if (packLbs > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Capturing package dimensions and multiplying each to each other in addition to weight to determine total cost
            Console.WriteLine("Please enter the package width:");
            int packW = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packL = Convert.ToInt32(Console.ReadLine());
            int packT = packH * packL * packW * packLbs / 100;
            // Comparing each dimension to 50 to see if the package fits within required dimensions
            if (packH > 50 || packL > 50 || packW > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + packT + ".00.");
                Console.WriteLine("Thank you!");
            }
        }
        Console.ReadLine();
    }
    }
