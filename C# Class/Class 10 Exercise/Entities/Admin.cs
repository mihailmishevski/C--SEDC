using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Admin : User
    {
        public Admin(string firstName, string lastName, string userName, string password) : base(firstName, lastName, userName, password)
        {

        }
    }
}
