using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public class StudentService : IUserService
    {
        public void LogIn(User user)
        {
            Console.WriteLine(user.Name + " student");
        }

        public void PrintInfromation(User user)
        {
            Console.WriteLine(user.Name + " Is a student");
        }
    }
}
