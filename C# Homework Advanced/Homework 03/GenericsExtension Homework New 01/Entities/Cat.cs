using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cat : Pet
    {
        public int LivesLeft { get; set; }

        public bool Lazy { get; set; }

        public Cat(string name, string type, int age, int livesLeft, bool lazy) : base(name, type, age)
        {
            LivesLeft = livesLeft;
            Lazy = lazy;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The {Age} {Type} {this.GetType()} {Name}, has {LivesLeft} lives left and is he lazy? {Lazy}");
        }
    }
}
