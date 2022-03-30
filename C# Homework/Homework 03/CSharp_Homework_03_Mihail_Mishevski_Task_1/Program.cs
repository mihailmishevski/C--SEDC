﻿using CSharp_Homework_03_Mihail_Mishevski_Task_1.Entities;
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
                int firstCar = Car(cars);
                int firstDriver = Driver(driver);

                Console.WriteLine("Now you will be choosing for the second car, make sure not to pick the same car twice!");

                int secondCar = Car(cars);

                while(secondCar == firstCar)
                {
                    Console.WriteLine("You can not pick the same car twice! Try again!;");
                    secondCar = Car(cars);
                }

                int secondDriver = Driver(driver);

                if (firstCar <= 0 || firstDriver <= 0 || secondCar <= 0 || secondDriver <= 0 ||
                   firstCar > 4 || firstDriver > 4 || secondCar > 4 || secondDriver > 4)
                {
                    Console.WriteLine("You entered the wrong parameters program stopping!");
                    return;
                }
                else
                {
                    Console.WriteLine(RaceCars(cars, driver, firstCar, secondCar, firstDriver, secondDriver));
                }
                Console.WriteLine("Race again!? Type yes to go again, no to stop!");

                goAgain = Console.ReadLine();
            }
                
        }


        public static string RaceCars(Car[] car, Driver[] driver, int firstCarIndex, int secondCarIndex, int firstDriverIndex, int secondDriverIndex)
        {
            if (car[firstCarIndex].CalculateSpeed(driver[firstDriverIndex].Skill) > car[secondCarIndex].CalculateSpeed(driver[secondDriverIndex].Skill))
            {
                return ($"{car[firstCarIndex].Model} with the driver {driver[firstDriverIndex].Name} is faster with speed of {car[firstCarIndex].CalculateSpeed(driver[firstDriverIndex].Skill)}");
            }
            else
            {
                return ($"{car[secondCarIndex].Model} with the driver {driver[secondDriverIndex].Name} is faster with the speed of {car[secondCarIndex].CalculateSpeed(driver[secondDriverIndex].Skill)}!");
            }
        }

        public static int Car(Car[] car)
        {
            Console.WriteLine("Choose the car you want to drive! Press - 1. Hyundai 2. Mazda 3. Ferrari 4. Porsche!");
            string firstCar = Console.ReadLine();
            bool firstCarBool = int.TryParse(firstCar, out int carInt);
            Console.WriteLine($"You chose {car[carInt].Model} as your car!");

            return carInt;
        }

        public static int Driver(Driver[] driver)
        {
            Console.WriteLine("Choose the driver of the car! Press - 1. Bob 2. Greg 3. Jill 4. Anne");
            string firstDriver = Console.ReadLine();
            bool firstDriverBool = int.TryParse(firstDriver, out int driverInt);
            Console.WriteLine($"You chose {driver[driverInt].Name} as your driver!");

            return driverInt;
        }
    }
}
