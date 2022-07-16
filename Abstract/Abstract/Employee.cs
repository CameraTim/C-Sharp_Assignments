using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // Inheriting from the Person abstract class
    public class Employee : Person
    {
        // Calling SayName from the Person class but overriding to modify its value
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
