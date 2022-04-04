using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Student : User
    {
        public Subject[] Subject { get; set; }

        public Student(string firstName, string lastName, Subject[] subject, string userName, string password) : base(firstName, lastName, userName, password)
        {
            Subject = subject;
        }
    }
}
