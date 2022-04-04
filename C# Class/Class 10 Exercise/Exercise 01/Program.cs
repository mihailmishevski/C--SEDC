using Entities;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new Admin("Mihail", "Mishevski", "mihail", "123"));
            users.Add(new Trainer("Zoran", "Zokla", "zoki", "zorla"));
            users.Add(new Student("Bob", "Bobski", new Subject[] { new Subject (SubjectName.Math, 5),
                                                                   new Subject (SubjectName.PE, 2),
                                                                   new Subject (SubjectName.Physics, 3)}
            , "bob", "bobler"));            

            


            Console.WriteLine("Enter your username");

            User foundUser = FoundUser(users);

            Console.WriteLine("Enter your password");

            PasswordCheck(foundUser);

            Console.WriteLine($"Welcome");
        }

        public static User FoundUser(List<User> users)
        {
            string userName = Console.ReadLine().ToLower();

            User foundUsername = users.Find(i => i.UserName.ToLower() == userName);

            if (foundUsername == null)
            {
                Console.WriteLine("That username doesn't exist!");
            }

            return foundUsername;
        }

        public static void PasswordCheck(User users)
        {
            string password = Console.ReadLine().ToLower();

            while(users.Password != password)
            {
                Console.WriteLine("Password not correct try again!");
                password = Console.ReadLine();
            }

            Console.WriteLine("Password correct!");
            return;
        }

        /*public static int UserIndex()
        {
            string userType = Console.ReadLine();
            bool userTypeBool = int.TryParse(userType, out int userIndex);

            while (!userTypeBool || userIndex < 1 || userIndex > 4)
            {
                Console.WriteLine("You entered something wrong");
                userType = Console.ReadLine();
                userTypeBool = int.TryParse(userType, out userIndex);
            }

            return userIndex;
        }*/

        /*public void Admin()
        {
            Console.WriteLine("Do you want to 1.add or 2.remove a teacher or a student?");

            string 

        }*/
    }
}
