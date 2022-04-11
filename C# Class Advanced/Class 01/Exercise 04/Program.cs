using Entities;
using System;
using System.Collections.Generic;

namespace Exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>()
            {
                new Teacher("Vlado", "vlado123", "Vlatko", "Vladimir"),
                new Student("Blazho", "blagoja123", "Blagojche", "Razbirash", -1),
                new Student("Stavre", "Stavre123", "Razlicno Ime", "Probuvam", -1),
                new Student("Boshko", "Boshko123", "Rabota", "Dali", -1),
                new Student("Dragan", "Dragan123", "Ima", "Ne", -1)
            };

            while (true)
            {
                Console.WriteLine("Welcome to the application!");

                User userFound = null;

                userFound = LogIn(users);

                if(userFound != null)
                {
                    if (userFound.GetType().Name == "Teacher")
                    {
                        TeacherLogged(users);
                    }

                    if (userFound.GetType().Name == "Student")
                    {
                        Student studentFound = (Student)userFound;

                        if (studentFound.Grade == -1)
                        {
                            studentFound.Grade = StudentLogged();
                        }
                        else
                        {
                            Console.WriteLine("You already took the test! Don't cheat!");
                        }
                    }
                }
            }
        }

        private static int StudentLogged()
        {
            int gradeAverage = 0;

            string questionAnswer = "";

            Console.WriteLine("Welcome student! Good luck on your test");

            Console.WriteLine("Q: What is the capital of Tasmania?\na: Dodoma\nb: Hobart\nc: Launceston\nd: Wellington");

            questionAnswer = Console.ReadLine();

            questionAnswer = AnswerTester(questionAnswer);

            if(questionAnswer.ToLower() == "b")
            {
                gradeAverage += 1;
            }

            Console.WriteLine("Q: What is the tallest building in the Republic of the Congo?\na: Kinshasa Democratic Republic of the Congo Temple\nb: Palais de la Nation\nc: Kongo Trade Centre\nd: Nabemba Tower");

            questionAnswer = Console.ReadLine();

            questionAnswer = AnswerTester(questionAnswer);

            if (questionAnswer.ToLower() == "d")
            {
                gradeAverage += 1;
            }

            Console.WriteLine("Q: Which of these is not one of Pluto's moons?\na: Styx\nb: Hydra\nc: Nix\nd: Lugia");

            questionAnswer = Console.ReadLine();

            questionAnswer = AnswerTester(questionAnswer);

            if (questionAnswer.ToLower() == "c")
            {
                gradeAverage += 1;
            }

            Console.WriteLine("Q: What is the smallest lake in the world?\na: Onega Lake\nb: Benxi Lake\nc: Kivu Lake\nd: Wakatipu Lake");

            questionAnswer = Console.ReadLine();

            questionAnswer = AnswerTester(questionAnswer);

            if (questionAnswer.ToLower() == "b")
            {
                gradeAverage += 1;
            }

            Console.WriteLine("Q: What country has the largest population of alpacas?\na: Chad\nb: Peru\nc: Australia\nd: Niger");

            questionAnswer = Console.ReadLine();

            questionAnswer = AnswerTester(questionAnswer);

            if (questionAnswer.ToLower() == "b")
            {
                gradeAverage += 1;
            }

            return gradeAverage;
        }

        private static string AnswerTester(string questionAnswer)
        {
            while (questionAnswer != "a" && questionAnswer != "b" && questionAnswer != "c" && questionAnswer != "d")
            {
                Console.WriteLine("Entered an option that is not presented! Enter again!");

                questionAnswer = Console.ReadLine();
            }

            return questionAnswer;
        }

        private static void TeacherLogged(List<User> users)
        {
            Console.WriteLine("Welcome teacher!");
            foreach(User user in users)
            {
                if(user.GetType().Name == "Student")
                {
                    Student student = (Student)user;

                    if (student.Grade < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{student.Name} {student.Surname}");
                    }

                    if (student.Grade > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{student.Name} {student.Surname}");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            string next = Console.ReadLine();
        }

        public static User LogIn(List<User> users)
        {
            int counter = 2;

            while (counter > 0)
            {
                Console.WriteLine("Enter your username");

                string username = Console.ReadLine();

                Console.WriteLine("Enter your password");

                string password = Console.ReadLine();

                foreach (User user in users)
                {
                    if (user.Username.ToLower() == username && user.Password == password)
                    {
                        Console.WriteLine($"Welcome {user.Name}");
                        return user;
                    }
                }

                Console.WriteLine($"Username or password don't match... {counter} tries left!");

                counter -= 1;
            }

            Console.WriteLine("Too many attempts, going back to main menu...");

            return null;
        }
    }
}
