using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Initializing string array
        string[] camera = { "1: Canon", "2: Nikon", "3: Fujifilm", "4: Sony", "5: Panasonic" };
        Console.WriteLine("Enter a camera from this list using a number:\n" + camera[0] + "\n" + camera[1] + "\n" + camera[2] + "\n" + camera[3] + "\n" + camera[4]);
        int selection = Convert.ToInt32(Console.ReadLine());
        // Subtracting result by 1 to match index number
        selection--;
        // Comparison in case user entry was not an index in the array
        if (selection > 4 || selection < 0)
        {
            Console.WriteLine("Sorry, that index does not exist.");
        }
        else
        {
            // Displaying the index selection
            Console.WriteLine(camera[selection]);
        }
        Console.ReadLine();

        // Initializing integer array
        int[] lucky = { 7, 13, 24, 66, 777 };
        Console.WriteLine("Choose one lucky number hidden in boxes 0-4:");
        int numSelect = Convert.ToInt32(Console.ReadLine());
        if (numSelect > 4 || numSelect < 0)
        {
            Console.WriteLine("Sorry, that index does not exist.");
        }
        else
        {
            Console.WriteLine(lucky[numSelect]);
        }
        Console.ReadLine();

        // Initializing list
        var social = new List<string>() { "YouTube", "Facebook", "Twitch", "Instagram" };
        Console.WriteLine("Select a social media platform by entering a number between 1-4");
        int socialSel = Convert.ToInt32(Console.ReadLine());
        socialSel--;
        if (socialSel > 3 || socialSel < 0)
        {
            Console.WriteLine("Sorry, that index does not exist.");
        }
        else
        {
            Console.WriteLine(social[socialSel]);
        }
        Console.ReadLine();
    }
}
