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

            Console.WriteLine($"Welcome {foundUser.GetType().Name} {foundUser.FirstName}!");

            switch (foundUser.GetType().Name)
            {
                case "Admin":
                    {
                        Console.WriteLine("Do you want to add/remove Trainers, Students, Admins?\n\n1.Add\n2.Remove");

                        string choice = Console.ReadLine();

                        if (choice.ToLower() == "add" || choice == "1")
                        {
                            Console.WriteLine("Do you want to add... \n\n1.Trainer\n2.Student\n3.Admin");

                            string index = Console.ReadLine();

                            bool indexBool = int.TryParse(index, out int indexInt);

                            if (!indexBool || indexInt > 3 || indexInt < 1)
                            {
                                Console.WriteLine("Entered a wrong value!");
                                return;
                            }

                            Add(users, indexInt);
                        }

                        else if (choice.ToLower() == "remove" || choice == "2")
                        {
                            Remove(users, foundUser);
                        }

                        else
                        {
                            Console.WriteLine("Didn't enter anything valid! Exiting...");
                            return;
                        }
                    }
                    break;

                case "Trainer":
                    {
                        Console.WriteLine("Do you want to see all students or all subjects?\n\n1.Students\n2.Subjects");

                        string index = Console.ReadLine();

                        if(index == "1" || index.ToLower() == "students")
                        {
                            Students(users);
                        }

                        else if (index == "2" || index.ToLower() == "subjects")
                        {
                            Subjects();
                        }

                        else
                        {
                            Console.WriteLine("Didn't enter anything valid! Exiting...");
                            return;
                        }
                    }
                    break;

                case "Student":
                    {
                        Console.WriteLine("How you doin!");
                    }
                    break;
            }
        }


        private static void Students(List<User> users)
        {
            foreach(User students in users)
            {
                if(students.GetType().Name == "Student")
                {
                    students.ShowInfo();
                }
            }
        }

        private static void Subjects()
        {

        }

        private static void Remove(List<User> users, User currentUser)
        {
            Console.WriteLine("Which user do you want to remove?");

            foreach (User user in users)
            {
                user.ShowInfo();
            }
            User foundUser = FoundUser(users);

            if(foundUser == currentUser)
            {
                Console.WriteLine("Cannot delete your own account! Exiting...");
                return;
            }

            users.Remove(foundUser);

            Console.WriteLine("User deleted!");

            foreach (User user in users)
            {
                user.ShowInfo();
            }
        }

        private static void Add(List<User> users, int index)
        {
            Console.WriteLine("Enter name");

            string name = Console.ReadLine();

            Console.WriteLine("Enter surname");

            string surname = Console.ReadLine();

            Console.WriteLine("Enter usename");

            string username = Console.ReadLine();

            Console.WriteLine("Enter password");

            string password = Console.ReadLine();

            if (index == 1)
            {
                users.Add(new Trainer(name, surname, username, password));
            }

            if (index == 2)
            {
                Console.WriteLine("Enter subjects of student");

                Subject[] subjects = Subject();

                users.Add(new Student(name, surname, subjects, username, password));
            }
        }

        public static Subject[] Subject()
        {
            string subject;

            int counter = 0;

            string grade;

            Subject[] newSubjects = new Subject[3];

            while (newSubjects.Length > counter)
            {
                Console.WriteLine("Which subjects does the student attend?\n\n1.Math\n2.PE\n3.Physics\n4.No more subjects");

                subject = Console.ReadLine();

                Console.WriteLine("What is his grade for that subject?");

                grade = Console.ReadLine();

                if (subject == "1" || subject.ToLower() == "math")
                {
                    newSubjects.Append(new Subject(SubjectName.Math, int.Parse(grade)));
                }

                if (subject == "2" || subject.ToLower() == "PE")
                {
                    newSubjects.Append(new Subject(SubjectName.Physics, int.Parse(grade)));
                }

                if (subject == "3" || subject.ToLower() == "Physics")
                {
                    newSubjects.Append(new Subject(SubjectName.PE, int.Parse(grade)));
                }

                if (subject == "4")
                {
                    break;
                }
                counter++;
            }

            return newSubjects;
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

            while (users.Password != password)
            {
                Console.WriteLine("Password not correct try again!");
                password = Console.ReadLine();
            }

            Console.WriteLine("Password correct!");
            return;
        }
    }

}
