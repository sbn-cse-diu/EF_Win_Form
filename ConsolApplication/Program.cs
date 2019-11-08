using DataAccess;
using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                Console.WriteLine("Enter Your Operation Code");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Create_Student(DB);
                        break;
                    case 2:
                        Update_Student(DB);
                        break;
                    case 3:
                        Delete_Student(DB);
                        break;
                    default:
                        Console.WriteLine("Wrong Operation");
                        break;
                }
                Console.WriteLine();
                DisplayStudents(DB.Students.ToList());
            }
            Console.ReadKey();
        }

        private static void Create_Student(SchoolDBContext DB)
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
        }

        private static void Update_Student(SchoolDBContext DB)
        {
            Console.WriteLine("Update Old Student");
            Console.Write("Enter Student ID : ");
            Student student = new Student();
            student.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Address: ");
            student.Address = Console.ReadLine();
            Console.Write("Phone: ");
            student.Phone = Console.ReadLine();
            
            DB.Students.Attach(student);
            DB.Entry(student).State = EntityState.Modified;
            DB.SaveChanges();
        }
        private static void Delete_Student(SchoolDBContext DB)
        {
            Console.WriteLine("Delete Old Student");
            Console.Write("Enter Student ID : ");
            Student student = new Student();
            student.ID = Convert.ToInt32(Console.ReadLine());

            DB.Students.Attach(student);
            DB.Entry(student).State = EntityState.Deleted;
            DB.SaveChanges();
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
