using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string> { "Tim", "Stephanie", "Eli", "Gianna" };
            Employee<int> emID = new Employee<int>();
            emID.things = new List<int> { 4, 5, 3, 19 };
            int total = employee.things.Count + emID.things.Count;
            for (int i = 0; i < total; i++)
                {
                    if (i < employee.things.Count)
                    {
                    Console.WriteLine(employee.things[i]);
                    }
                    else
                    {
                    int j = i - employee.things.Count;
                    Console.WriteLine(emID.things[j]);
                    }
                }
            Console.ReadLine();
        }
    }
}
