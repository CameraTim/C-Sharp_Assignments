using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating object on Employee class
            Employee employee = new Employee();
            // Assigning values to the employee object (inherited from the Person class)
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // Calling the SayName method from the Person class
            employee.SayName();
            Console.ReadLine();
        }
    }
}
