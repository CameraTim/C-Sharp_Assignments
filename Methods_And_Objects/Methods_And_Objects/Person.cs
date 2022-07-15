using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects
{
    public class Person
    {
        // Assigning properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Method that, when called, will display the values assigned to the first and last names
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
