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
            using (SchoolDBContext DB = new SchoolDBContext())
            {
                Console.WriteLine("Insert New Student");
                Student student = new Student();
                Console.Write("Name: ");
                student.Name = Console.ReadLine();
                Console.Write("Address: ");
                student.Address = Console.ReadLine();
                Console.Write("Phone: ");
                student.Phone = Console.ReadLine();

                DB.Students.Add(student);
                DB.SaveChanges();

                DisplayStudents(DB.Students.ToList());
            }
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
