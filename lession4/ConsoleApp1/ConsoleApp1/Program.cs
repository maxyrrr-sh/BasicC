using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class StudentRegistry
    {
        static List<Student> stList = new List<Student>();

        static StudentRegistry()
        {

        }

        public static void AddStudent(Student addSt)
        {
            stList.Add(addSt);
        }

        public static void RemoveStudent(Student delSt)
        {
            stList.Remove(delSt);
            Console.WriteLine($"Success! The student with sequence number {delSt} has been deleted!");
        }

        public static string GetAllInfo()
        {
            string print = null;
            int n = 1;
            foreach (var student in stList)
            {
                print += n.ToString() + "." + student.GetStudentInfo();
                n++;
            }

            return print;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte a;
            do
            {
                Console.Clear();
                Console.Write(" 1) Add student;\n 2) Remove student; \n 3) Get alllll info; \n 0) Exit \n\tYour choise: ");
                a = Convert.ToByte(Console.ReadLine());
                
                if (a == 1)
                {
                    Console.WriteLine("Input: Name, Surname, date of entry, country, city, address");
                    StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
                    continue;
                } else if (a == 2)
                {
                    Console.Write("Enter student`s sequence number to delete: ");
                    byte x = Convert.ToByte(Console.ReadLine());

                } else if (a == 3)
                    Console.WriteLine(StudentRegistry.GetAllInfo());
                else
                {
                    break;
                }

            } while (a != 0 );
         
        }
    }
}
