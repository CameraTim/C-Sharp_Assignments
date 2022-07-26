using System;

namespace Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Tim" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

        }
    }
}
