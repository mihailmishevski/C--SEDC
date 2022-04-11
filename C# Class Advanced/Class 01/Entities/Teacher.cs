using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Teacher : User
    {
        public Teacher(string username, string password, string name, string surname) : base(username, password, name, surname)
        {
        }
    }
}
