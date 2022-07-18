using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            // Assigning values to both objects
            employee1.FirstName = "Tim";
            employee1.LastName = "Seneker";
            employee1.ID = 5;
            employee2.FirstName = "Not Tim";
            employee2.LastName = "Seneker";
            employee2.ID = 6;
            // Using overloaded operators to compare ID values of the objects as defined by the Employee class
            if (employee1 == employee2)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same silly goose.");
            }
            if (employee1 != employee2)
            {
                Console.WriteLine("They are not the same");
            }
            else
            {
                Console.WriteLine("They are the same");
            }
            Console.ReadLine();
        }
    }
}
