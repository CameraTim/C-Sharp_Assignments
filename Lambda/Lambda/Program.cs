using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Employee list
            List<Employee> employee = new List<Employee>()
            {
                // Creating new Employees adding values to each class property
                new Employee() {ID = 2, fName = "Joe", lName = "Thomas" },
                new Employee() {ID = 7, fName = "Tommy", lName = "Smith" },
                new Employee() {ID = 4, fName = "Jordan", lName = "Michael" },
                new Employee() {ID = 69, fName = "Jimmy", lName = "Neutron" },
                new Employee() {ID = 3, fName = "Joe", lName = "Petry" },
                new Employee() {ID = 1, fName = "Joanna", lName = "Daigle" },
                new Employee() {ID = 6, fName = "John", lName = "Jacobjenkleheimerschmit" },
                new Employee() {ID = 8, fName = "Gianna", lName = "Raye" },
                new Employee() {ID = 15, fName = "Rachael", lName = "Blackburn" },
                new Employee() {ID = 5, fName = "Piper", lName = "Peppercorn" }
            };
            
            // Instantiating new list to check for "Joe"
            List<Employee> joePeeps = new List<Employee>();
            // Foreach loop to add any Employee with the first name Joe to the new list
            foreach (Employee person in employee)
            {
                if (person.fName == "Joe")
                {
                    joePeeps.Add(person);
                    Console.WriteLine(person.fName);
                }
            }
            // Lambda function to add any Employee with the first name Joe to a new list
            List<Employee> joePeople = employee.Where(x => x.fName == "Joe").ToList();
            foreach (Employee peep in joePeople)
            {
                Console.WriteLine(peep.fName);
            }
            // Checking ID's to add any Employee with an ID greater than 5 to a new list
            List<Employee> specialID = employee.Where(x => x.ID > 5).ToList();
            foreach (Employee VIP in specialID)
            {
                Console.WriteLine(VIP.fName + " " + VIP.lName);
            }
            Console.ReadLine();
        }
    }
}
