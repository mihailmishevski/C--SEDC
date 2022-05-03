using Interface_Exercise_01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise_01.Entities
{
    public class Student : User, IStudent
    {
        public List<int> Grade { get; set; }

        public Student(int id, string name, string username, string password, List<int> grades) : base(id, name, username, password)
        {
            Grade = grades;
        }

        public override void PrintUser()
        {
            base.PrintUser();
            Grade.ForEach(Console.WriteLine);
        }
    }
}
