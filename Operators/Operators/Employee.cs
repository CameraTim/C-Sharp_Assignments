using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        // Assigning properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        // Overloading == operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Comparing both object ID's to see if they match
            bool check = false;
            if (employee1.ID == employee2.ID)
            {
                check = true;
            }
            return check;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool check = false;
            if (employee1.ID != employee2.ID)
            {
                check = true;
            }
            return check;
        }
    }
}
;