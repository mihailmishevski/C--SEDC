using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() 
            { new Car(1, "Porsche", "Something", Color.Red, 30000, DateTime.Now),
              new Car(2, "Something", "Nothing", Color.Green, 500000, DateTime.Now),
              new Car(3, "Ford", "Qwe", Color.Red, 1230000, DateTime.Now),
              new Car(4, "Ford", "Asd", Color.Red, 34500, DateTime.Now),
              new Car(5, "Ford", "Zxc", Color.Red, 6000000, DateTime.Now)
            };

            int totalCostRedCar = 0;

            int totalCostFordCar = 0;

            foreach (Car car in cars)
            {
                if(car.Color == Color.Red)
                {
                    totalCostRedCar += car.CalculatePrice();
                }
            }

            foreach (Car car in cars)
            {
                if (car.BrandName == "Ford")
                {
                    totalCostFordCar += car.CalculatePrice();
                }
            }

            Console.WriteLine($"Total cost of all the Red cars is {totalCostRedCar}");

            Console.WriteLine($"Total cost of all the Ford cars is {totalCostFordCar}");

            Console.WriteLine("Cars that have travelled more then 100.000KMs are!");

            foreach (Car car in cars)
            {
                if (car.Distance >= 100000)
                {
                    Console.WriteLine($"{car.Id} {car.BrandName} {car.ModelName} {car.Color}");
                }
            }
        }
    }
}
