using DataAccess;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDBContext DB = new SchoolDBContext();
            DisplayStudents(DB.Students.ToList());
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void DisplayStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
