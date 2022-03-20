using Class.Entities;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Human humanOne = new Human()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Age = int.Parse(Console.ReadLine())
                        };

                        humanOne.GetPersonStats();*/

            /*            Dog dogOne = new Dog(
                            Console.ReadLine(),
                            Console.ReadLine(),
                            Console.ReadLine());

                        dogOne.DogInfo();
                        dogOne.NowEating();
                        dogOne.Play();
                        dogOne.ChaseTail();*/
            /*
                        Dog dogOne = new Dog()
                        {
                            Name = "Sharko",
                            Age = 3,
                            Weight = 30
                        };

                        Console.WriteLine(dogOne.Name);*/

            /*            Program program = new Program();

                        Program.SayHelloStatic();

                        program.SayHello();*/

            Student[] Students = new Student[5];

            for(int a = 0; a < Students.Length; a++)
            {
                Console.WriteLine("Enter the student name, their academy and group number");

                Student instancedStudent = new Student(
                    Console.ReadLine(),
                    Console.ReadLine(),
                    Console.ReadLine());
                Students[a] = instancedStudent;
            };

            Console.WriteLine("Enter to check if that name already exists!");
            string nameCheck = Console.ReadLine();

            for(int b = 0; b < Students.Length; b++)
            {
                if(Students[b].Name.ToLower() == nameCheck.ToLower())
                {
                    Console.WriteLine("That name exists!");
                    break;
                }
            }
        }

        /*        static void SayHelloStatic()
                {
                    Console.WriteLine("Hello Static");
                }

                void SayHello()
                {
                    Console.WriteLine("Hello World");
                }*/
    }
}
