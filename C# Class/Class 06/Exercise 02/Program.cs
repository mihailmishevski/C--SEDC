using Exercise_02.Entities;
using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users =
            {
                new User(0, "Mihail", "123", new string [] {"Hello"}),
                new User(1, "Blazho", "345", new string [] {"Goodbye"}),
                new User(2, "Mirko", "567", new string [] {"Hey and goodbye"})
            };

            Console.WriteLine("Do you want to (L)og in or (R)egister?");
            string options = Console.ReadLine();

            switch (options.ToLower())
            {
                case "l":
                    Log(users);
                    break;
                case "r":
                    Register(users);
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }

        }

        private static void Register(User[] users)
        {
            Console.WriteLine("Enter your id (only numbers allowed): ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int id);

            if (!isValidInput)
            {
                Console.WriteLine("The entered ID is not valid!");
                return;
            }

            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            if (string.IsNullOrEmpty(username)) // null, ""
            {
                Console.WriteLine("Invalid username. Username cannot be empty!");
                return;
            }

            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(password)) // null, ""
            {
                Console.WriteLine("Invalid password, Password cannot be empty!");
                return;
            }

            User user = FindUserByUserName(username, users);

            if (user != null)
            {
                Console.WriteLine($"{user.Username} is taken.");
                return;
            }

            user = new User(id, username, password, new string[] { });

            Array.Resize(ref users, users.Length + 1);

            users[users.Length - 1] = user;

            Console.WriteLine($"Registation of user {user.Username} was successful!");

            PrintUsers(users);
        }

        private static void PrintUsers(User[] users)
        {
            foreach (User user in users)
            {
                string userInfo = user.GetIdAndUsername();
                Console.WriteLine(userInfo);
            }
        }

        private static void Log(User[] users)
        {
            Console.WriteLine("Welcome, can you enter the username");
            string username = Console.ReadLine();

            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Invalid username. Username cannot be empty!");
                return;
            }

            Console.WriteLine("Please enter your password!");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Invalid password. Password cannot be empty!");
                return;
            }

            User user = FindUserByUserName(username, users);

            Console.WriteLine($"Welcome {user}, here are your messages");
            user.PrintMessages();
        }

        private static User FindUserByUserName(string username, User[] users)
        {
            User foundUser = null;

            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    foundUser = user;
                    break;
                }
            }

            return foundUser;
        }
    }
}
