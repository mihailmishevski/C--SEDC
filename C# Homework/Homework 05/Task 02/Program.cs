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
                {1, new User (1, "Mihail", "Mishevski", DateTime.Now)},
                {2, new User (2, "Blazho", "Blazhevski", DateTime.Now)}
            };

            Console.WriteLine("Hello user!\nDo you want to (R)egister or (S)search?");
            string enterPrompt = Console.ReadLine().ToLower();

            switch (enterPrompt)
            {
                case "r":
                    Register(users);
                    break;

                case "register":
                    Register(users);
                    break;

                case "search":
                    Search(users);
                    break;

                case "s":
                    Search(users);
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }
        }

        static void Register(Dictionary<int, User> users)
        {
            Console.WriteLine("Please enter the required information so we enter you in the database!");
            users.Add(users.Count + 1, new User(Id(users), Name("first"), Name("last"), DateTime.Now));
        }

        static void Search(Dictionary<int, User> users)
        {
            Console.WriteLine("Please enter the name, surname or the ID of the person you are looking for!");
            string searchInput = Console.ReadLine();
            bool searchInputBool = int.TryParse(searchInput, out int searchInt);

            foreach (var person in users)
            {
                if(person.Value.FirstName == searchInput.ToLower() || person.Value.LastName == searchInput.ToLower() || person.Value.Id == searchInt)
                {
                    Console.WriteLine($"ID = {person.Value.Id}, First Name = {person.Value.FirstName}, Last Name = {person.Value.LastName}, Registered = {person.Value.CreatedOn}");
                }
                else
                {
                    Console.WriteLine("User not found!");
                }
            }
        }

        static int Id(Dictionary<int, User> users)
        {
            int check = -1;

            Console.WriteLine("Enter the Id that you want to have!");
            string id = Console.ReadLine();
            bool idBool = int.TryParse(id, out int idIndex);

            check = CheckId(users, idIndex);

            while (check == -1 || !idBool)
            {
                Console.WriteLine("Please enter a valid Id digit for your ID.");
                id = Console.ReadLine();
                idBool = int.TryParse(id, out idIndex);

                check = CheckId(users, idIndex);
            }

            return idIndex;
        }

        static int CheckId(Dictionary<int, User> users, int idIndex)
        {
            foreach (var item in users)
            {
                if(item.Value.Id == idIndex)
                {
                    Console.WriteLine("That Id is already in use!");
                    return -1;
                }
            }
            return 1;
        }

        static string Name(string firstLast)
        {
            Console.WriteLine($"Please enter your {firstLast} name.");
            string name = Console.ReadLine();

            return name;
        }
    }
}
