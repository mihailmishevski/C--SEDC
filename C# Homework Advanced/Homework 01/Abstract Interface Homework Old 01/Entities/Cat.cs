using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Cat : Animal, ICat
    {
        public Cat(string name, string color) : base(name, color)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} {Color} eats {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This animal is called {Name} and he is {Color}");
        }
    }
}
