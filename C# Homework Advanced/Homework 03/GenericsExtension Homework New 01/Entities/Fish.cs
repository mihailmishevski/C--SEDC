using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public int Size { get; set; }

        public Fish(string name, string type, int age, int size, string color) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The {Age} {Type} {this.GetType()} {Name} is colored {Color} and it's size is {Size}");
        }
    }
}
