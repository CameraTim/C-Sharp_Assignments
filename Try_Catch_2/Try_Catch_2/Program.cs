using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            do
            {
                try
                {
                    Console.WriteLine("What is your age?");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 1)
                    {
                        throw new Negative();
                    }
                    int Year = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in " + Year);
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number.");
                }
                catch (Negative)
                {
                    Console.WriteLine("Age cannot be a negative number or 0.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error has occured");
                    Console.ReadLine();
                    return;
                }
            } while (age <= 0);
            
        }
    }
}
