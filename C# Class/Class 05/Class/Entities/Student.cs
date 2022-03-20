using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Entities
{
    internal class Student
    {
        public string Name;

        public string Academy;

        public string Group;

        public Student(string studentName, string studentAcademy, string studentGroup)
        {
            Name = studentName;
            Academy = studentAcademy;
            Group = studentGroup;
        }
    }
}
