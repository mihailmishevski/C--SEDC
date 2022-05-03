using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, string color) : base(name, color)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} the dog is barking!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This animal is called {Name} and he is {Color}");
        }
    }
}
