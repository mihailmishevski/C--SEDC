using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public User(string username, string password, string name, string surname)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
        }
    }
}
