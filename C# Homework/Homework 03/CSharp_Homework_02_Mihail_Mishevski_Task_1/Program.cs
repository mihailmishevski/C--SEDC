using CSharp_Homework_02_Mihail_Mishevski_Task_1.Entities;
using System;

namespace CSharp_Homework_02_Mihail_Mishevski_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car("Placeholder", 0),
                new Car("Hyundai", 10),
                new Car("Mazda", 20),
                new Car("Ferrari", 30),
                new Car("Porsche", 40)
            };

            Driver[] driver =
            {
                new Driver("Placeholder", 0),
                new Driver("Bob", 1),
                new Driver("Greg", 2),
                new Driver("Jill", 3),
                new Driver("Anne", 4)
            };

            Console.WriteLine("We will compare two drivers with two cars and see who is faster!");

            Console.WriteLine("If you want to proceed type yes, if you want to stop type no!");

            string goAgain = Console.ReadLine();

            if(goAgain.ToLower() != "no" && goAgain.ToLower() != "yes")
            {
                Console.WriteLine("You didn't press yes or no, tough luck try again!");
                return;
            }

            if (goAgain.ToLower() == "no")
            {
                return;
            }

            while (goAgain.ToLower() == "yes")
            {
                Console.WriteLine("Choose the first car! Press - 1. Hyundai 2. Mazda 3. Ferrari 4. Porsche!");
                string firstCar = Console.ReadLine();
                bool firstCarBool = int.TryParse(firstCar, out int firstCarInt);

                Console.WriteLine("Choose the driver of the first car! Press - 1. Bob 2. Greg 3. Jill 4. Anne");
                string firstDriver = Console.ReadLine();
                bool firstDriverBool = int.TryParse(firstDriver, out int firstDriverInt);
            
                Console.WriteLine("Choose the second car! Press - 1. Hyundai 2. Mazda 3. Ferrari 4. Porsche!");
                string secondCar = Console.ReadLine();
                bool secondCarBool = int.TryParse(secondCar, out int secondCarInt);

                Console.WriteLine("Choose the driver of the second car! Press - 1. Bob 2. Greg 3. Jill 4. Anne");
                string secondDriver = Console.ReadLine();
                bool secondDriverBool = int.TryParse(secondDriver, out int secondDriverInt);

                if (firstCarInt <= 0 || firstDriverInt <= 0 || secondCarInt <= 0 || secondDriverInt <= 0 ||
                   firstCarInt > 4 || firstDriverInt > 4 || secondCarInt > 4 || secondDriverInt > 4)
                {
                    Console.WriteLine("You entered the wrong parameters program stopping!");
                    return;
                }
                else
                {
                    RaceCars();
                }

                void RaceCars()
                {
                    if (cars[firstCarInt].CalculateSpeed(driver[firstDriverInt].Skill) > cars[secondCarInt].CalculateSpeed(driver[secondDriverInt].Skill))
                    {
                        Console.WriteLine($"{cars[firstCarInt].Model} with the driver {driver[firstDriverInt].Name} is faster with speed of {cars[firstCarInt].CalculateSpeed(driver[firstDriverInt].Skill)}");
                    }
                    else
                    {
                        Console.WriteLine($"{cars[secondCarInt].Model} with the driver {driver[secondDriverInt].Name} is faster with the speed of {cars[secondCarInt].CalculateSpeed(driver[secondDriverInt].Skill)}!");
                    }
                }

                Console.WriteLine("Race again!? Type yes to go again, no to stop!");

                goAgain = Console.ReadLine();
            }
                
        }
    }
}
