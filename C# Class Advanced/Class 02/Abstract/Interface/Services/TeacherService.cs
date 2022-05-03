using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public class TeacherService : IUserService
    {
        public void LogIn(User user)
        {
            Console.WriteLine(user.Name + " Teacher");
        }

        public void PrintInfromation(User user)
        {
            Console.WriteLine(user.Name + " is a teacher");
        }
    }
}
