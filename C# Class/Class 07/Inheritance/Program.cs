using Inheritance.Entities;
using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape("Red");
            Circle circle = new Circle(1.5m, "Blue");

            Console.WriteLine($"{shape.Color} is the color of the shape");
            Console.WriteLine($"{circle.Radius} is the radius of the circle with the color {circle.Color}");
        }
    }
}
