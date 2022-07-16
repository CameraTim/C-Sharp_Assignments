using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Creating abstract class
    public abstract class Person
    {
        // Adding string values to be inherited
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Adding abstract method so it has no body
        public abstract void SayName();
    }
}
