using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating array
        string[] camera = { "Canon ", "Sony ", "Fujifilm " };
        Console.WriteLine("Please enter a model type:");
        string model = Console.ReadLine();
        // for loop to add string to end of each item in array
        for (int i = 0; i < camera.Length; i++)
        {
            camera[i] = camera[i] + model;
        }
        // Display each new string
        foreach (string type in camera)
        {
            Console.WriteLine(type);
        }

        // Creating a while loop
        int a = 0;
        while (a < 10)
        {
            Console.WriteLine("a = " + a);
            // Loop fixed by adding iteration to a
            a++;
        }

        Console.WriteLine("Please enter a number:");
        int entry = Convert.ToInt32(Console.ReadLine());
        // Setting a do while loop to ensure the command runs at least one time depending on the number entered
        do
        {
            Console.WriteLine("Your number is currently: " + entry);
            entry++;
        } while (entry <= 100);

        // Creating a list
        List<string> theList = new List<string> { "YouTube", "Facebook", "Instagram", "Twitch", "TikTok", "Twitter" };
        Console.WriteLine("Enter a social media platform:");
        string social = Console.ReadLine();
        // Instantiating two integers, the second to determine the max iterations the foreach loop will go through
        int index = 0;
        int indexCount = theList.Count;
        foreach (string socials in theList)
        {
            if (socials == social)
            {
                // If the user entry matches a string in the list, the loop breaks
                Console.WriteLine(socials + " is in index: " + index);
                break;
            }
            else
            {
                // If the current iteration and the user entry don't match, a manual iteration is added
                index++;
                // Once the manual iteration reaches the list count, the user entry has confirmed to not match any list item
                if (index == indexCount)
                {
                    Console.WriteLine("Sorry, that platform is not listed.");
                    break;
                }
            }
        }

        List<string> dupList = new List<string> { "Tim", "Stephanie", "Elijah", "Gianna", "Dani", "Tim", "Elijah" };
        // Creating a blank list to add entries to
        List<int> dupEntries = new List<int> { };
        Console.WriteLine("Please enter a name:");
        string name = Console.ReadLine();
        int dupIndex = 0;
        int dupIndCount = dupList.Count;
        // Setting a boolean to false by default in case the user entry doesn't match a name in the list
        bool nameCheck = false;
        foreach (string names in dupList)
        {
            if (names == name)
            {
                // If the user entry matches the current iterated name, the current dupIndex number will be assigned to the new list
                dupEntries.Add(dupIndex);
                // Setting to true so the index display shows below
                nameCheck = true;
            }
            dupIndex++;
            if (dupIndex == dupIndCount)
            {
                if (nameCheck == false)
                {
                    Console.WriteLine("Sorry, that name is not listed.");
                    break;
                }
                else
                {
                    // Runs when nameCheck has confirmed at least one name matches
                    Console.WriteLine(name + " appears in the following indexes:");
                    // Writes each matching entry to console
                    dupEntries.ForEach(Console.WriteLine);
                }
            }
        }

        List<string> uniList = new List<string> { "Dillan", "Bob", "Bob", "Smiley", "Seneker", "Tim", "Tim", "Bob", "Miller" };
        List<string> uniListCheck = new List<string> { };
        // First foreach to run through the original list
        foreach (string uniName in uniList)
        {
            // Placing int index counts inside the first foreach loop so that the count resets after the second foreach completes each full iteration
            int uniIndex = 0;
            int uniIndCount = uniListCheck.Count;
            // This if condition is for the first iteration only so that it doesn't get falsely tagged as duplicate
            if (uniIndCount == 0)
            {
                Console.WriteLine(uniName + " is unique.");
                uniListCheck.Add(uniName);
            }
            else
            {
                // Second foreach compares all the strings that have been written to it so far with the current iteration of the original list
                foreach (string i in uniListCheck)
                {
                    uniIndex++;
                    // Comparison to check and see if the name has already been written in the new list
                    if (i == uniName)
                    {
                        // When a name matches, it is a duplicate and doesn't need to be written to the new list again
                        Console.WriteLine(uniName + " is a duplicate.");
                        break;
                    }
                    // Once all the names in the new list have been checked, the name is unique and is written into the list
                    else if (uniIndex == uniIndCount)
                    {
                        Console.WriteLine(uniName + " is unique.");
                        uniListCheck.Add(uniName);
                        break;
                    }
                }
            }
        }
        Console.ReadLine();
    }
}

