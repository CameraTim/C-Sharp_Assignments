using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Inheriting from the Person abstract class
    public class Employee : Person, IQuitTable
    {
        // Calling SayName from the Person class but overriding to modify its value
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        // Calling method from interface
        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.firstName + " " + employee.lastName + " has just left the building.");
        }
    }
}
