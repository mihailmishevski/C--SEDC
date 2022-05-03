using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndPolymorphism.Entities
{
    public class User
    {
        public static int USERNAME_MAX_LENGTH = 255;

        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
