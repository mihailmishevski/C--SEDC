using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public Dog(string name, string type, int age, string favoriteFood) : base(name, type, age)
        {
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The {Age} {Type} {this.GetType()} {Name} has a favorite food {FavoriteFood}");
        }
    }
}
