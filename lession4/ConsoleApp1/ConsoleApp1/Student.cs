using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        string name;
        string surname;
        string dateOFentry;
        StudentAddress stAddress;

        public Student()
        {
        }

        public Student(string name, string surname, string dateOFentry, StudentAddress stAddress)
        {
            this.name = name;
            this.surname = surname;
            this.dateOFentry = dateOFentry;
            this.stAddress = stAddress;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string DateOFentry
        {
            get { return dateOFentry; }
            set { dateOFentry = value; }
        }

        public StudentAddress StAddress
        {
            get { return stAddress; }
            set { stAddress = value; }
        }

        public string GetStudentInfo()
        {
            return ($"Students info: \n\tName:{Name}\n\tSurname:{Surname}\n\tThe date of entry: {DateOFentry}\n\tAddress: {StAddress}\n");
        }
    }
}
