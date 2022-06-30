using System;
class Program
{
    static void Main()
    {
        // Assigning a boolean value false to guess as the trigger for the while loop
        bool guess = false;
        // Setting the while loop to when guess = false
        while (!guess)
        {
            // Creating a user input
            Console.WriteLine("Enter a number between 1-5:");
            string num = Console.ReadLine();
            // Running through the numbers to determine which case to run based on the input
            switch (num)
            {
                case "1":
                    Console.WriteLine("You wrote 1, THAT'S THE WRONG NUMBA!  Press Enter to try again.");
                    break;
                case "2":
                    Console.WriteLine("You wrote 2, THAT'S THE WRONG NUMBA!  Press Enter to try again.");
                    break;
                case "3":
                    Console.WriteLine("You wrote 3, THAT'S THE WRONG NUMBA!  Press Enter to try again.");
                    break;
                case "4":
                    Console.WriteLine("You wrote 4, THAT'S THE WRONG NUMBA!  Press Enter to try again.");
                    break;
                case "5":
                    Console.WriteLine("You wrote 5!  That's the correct number!");
                    // Assigning true to guess to break the while loop
                    guess = true;
                    break;
                // When any other input besides a 1-5 is entered
                default:
                    Console.WriteLine("Hm...  That doesn't look like a 1-5 to me.  Press Enter to try again.");
                    break;
            }
            Console.ReadLine();
        }

        // Generating a random integer
        Random ranNum = new Random();
        // Using Next() to return a positive integer within the specified range
        int ranSelect = ranNum.Next(250, 9750);
        int ranGuess;
        int guessAmount = 0;
        do
        {
            Console.WriteLine("Try to guess a number within 250.  Number must be between 0-10000:");
            ranGuess = Convert.ToInt32(Console.ReadLine());
            // Iterating the guessAmount to count number of guesses
            guessAmount++;
            // Determining whether the user input was over 250 or under 250 to see if the user guessed a close enough number
            if (ranSelect - ranGuess > 250 || ranSelect - ranGuess < -250)
            {
                // If statement for determining whether the user input was higher or lower than the random number
                if (ranSelect > ranGuess)
                {
                    Console.WriteLine("Oops!  That number was too low, try again.");
                }
                else
                {
                    Console.WriteLine("Oops!  That number was too high, try again.");
                }
            }
            else
            {
                Console.WriteLine("Congrats! " + ranGuess + " was within 250.  The exact number was " + ranSelect + ".  It took you " + guessAmount + " guesses.");
            }
        }
        // While loop the same as the first If statement to check for the same conditions but to close when the requirement is met
        while (ranSelect - ranGuess > 250 || ranSelect - ranGuess < -250);
        Console.ReadLine();
    }
}
