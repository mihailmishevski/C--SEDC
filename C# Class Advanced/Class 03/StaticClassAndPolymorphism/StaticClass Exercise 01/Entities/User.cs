using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass_Exercise_01.Entities
{
    public class User
    {
        public const int USERNAME_MAX_LENGTH = 255;

        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
