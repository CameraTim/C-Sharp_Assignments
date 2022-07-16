using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class that inherits from the abstract class, assigning values and calling the method to print the values to the console
            Employee employee = new Employee();
            // Creating object from an interface
            IQuitTable quitTable = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            quitTable.Quit(employee);
            Console.ReadLine();
        }
    }
}
