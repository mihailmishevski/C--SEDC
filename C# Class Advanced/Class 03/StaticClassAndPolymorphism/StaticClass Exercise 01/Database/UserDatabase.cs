﻿using StaticClass_Exercise_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass_Exercise_01.Database
{
    public static class UserDatabase
    {
        public static List<User> USERS = new List<User>()
        {
            new User("Miki"),
            new User("Dragan"),
            new User("Bojan"),
            new User("Dimitar")
        };
    }
}
