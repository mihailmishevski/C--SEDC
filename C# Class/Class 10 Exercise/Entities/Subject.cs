using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Subject
    {
        public SubjectName Subjects { get; set; }

        public int Grades { get; set; }

        public Subject(SubjectName subjects, int grades)
        {
            Subjects = subjects;
            Grades = grades;
        }
    }
}
