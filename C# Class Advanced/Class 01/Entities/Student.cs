using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Student : User
    {
        public int Grade { get; set; }

        public Student(string username, string password, string name, string surname, int grade) : base(username, password, name, surname)
        {
            Grade = grade;
        }
    }
}
