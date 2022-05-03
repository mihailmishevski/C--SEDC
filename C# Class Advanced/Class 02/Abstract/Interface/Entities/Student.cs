using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    public class Student : User
    {

        public string ClassName { get; set; }
        public Student(string name, string className) : base(name)
        {
            ClassName = className;
        }
    }
}
