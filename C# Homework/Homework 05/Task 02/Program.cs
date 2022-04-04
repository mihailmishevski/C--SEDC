using Entities;
using System;
using System.Collections.Generic;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>
            {
                {1, new User { Id = 1, FirstName = "Mihail", LastName = "Mishevski", CreatedOn = DateTime.Now } }
            };
        }
    }
}
