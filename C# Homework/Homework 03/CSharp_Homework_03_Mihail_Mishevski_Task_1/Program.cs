using CSharp_Homework_03_Mihail_Mishevski_Task_1.Entities;
using System;

namespace CSharp_Homework_03_Mihail_Mishevski_Task_1
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

            bool check = true;

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

                int firstCarIndex = ReadCarIndexInput();

                int firstDriverIndex = ReadDriverIndexInput();

                if (firstCarIndex == -1)
                {
                    Console.WriteLine("Invalid index");
                    break;
                }

                Car firstCar = GetCar(cars, firstCarIndex);

                Driver firstDriver = Driver(driver, firstDriverIndex);

                Console.WriteLine("Now you will be choosing for the second car, make sure not to pick the same car twice!");

                int secondCarIndex = ReadCarIndexInput();

                while (check)
                {
                    if (firstCarIndex == secondCarIndex)
                    {
                        Console.WriteLine("You cannot chose the same car twice! Enter a new number!");
                        secondCarIndex = ReadCarIndexInput();
                    }
                    else
                    {
                        check = false;
                    }
                }

                int secondDriverIndex = ReadDriverIndexInput();

                Car secondCar = GetCar(cars, secondCarIndex);

                Driver secondDriver = Driver(driver, secondDriverIndex);

                Console.WriteLine(RaceCars(firstCar, firstDriver, secondCar, secondDriver));
                
                Console.WriteLine("Race again!? Type yes to go again, no to stop!");

                goAgain = Console.ReadLine();
            }
                
        }


        public static string RaceCars(Car carOne, Driver driverOne, Car carTwo, Driver driverTwo)
        {
            if (carOne.CalculateSpeed(driverOne.Skill) > carTwo.CalculateSpeed(driverTwo.Skill))
            {
                return ($"{carOne.Model} with the driver {driverOne.Name} is faster with speed of {carOne.CalculateSpeed(driverOne.Skill)}");
            }
            else
            {
                return ($"{carTwo.Model} with the driver {driverTwo.Name} is faster with the speed of {carTwo.CalculateSpeed(driverTwo.Skill)}!");
            }
        }

        public static Car GetCar(Car[] car, int carIndex)
        {
            return car[carIndex];
        }

        public static int ReadCarIndexInput()
        {
            Console.WriteLine("Choose the car you want to drive! Press - 1. Hyundai 2. Mazda 3. Ferrari 4. Porsche!");
            string firstCar = Console.ReadLine();
            bool canParseFirstCar = int.TryParse(firstCar, out int carIndex);

            if (!canParseFirstCar || (carIndex > 4 || carIndex < 0))
            {
                return -1;
            }

            return carIndex;
        }

        public static Driver Driver(Driver[] driver, int driverIndex)
        {
            return driver[driverIndex];
        }

        public static int ReadDriverIndexInput()
        {
            Console.WriteLine("Choose the driver of the car! Press - 1. Bob 2. Greg 3. Jill 4. Anne");
            string firstDriver = Console.ReadLine();
            bool canParseFirstDriver = int.TryParse(firstDriver, out int driverIndex);

            if (!canParseFirstDriver || (driverIndex > 4 || driverIndex < 0))
            {
                return -1;
            }

            return driverIndex;
        }
    }
}
