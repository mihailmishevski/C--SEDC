using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Entities
{
    internal class Dog
    {
        public string Name;

        public string Race;

        public string Color;

        public Dog(string dogName, string dogRace, string dogColor)
        {
            Name = dogName;
            Race = dogRace;
            Color = dogColor;
        }

        public void DogInfo()
        {
            Console.WriteLine($"{Name}, the {Race} is {Color}");
        }

        public void NowEating()
        {
            Console.Write("The dog is now eating!");
        }

        public void Play()
        {
            Console.Write("The dog is now playing!");
        }

        public void ChaseTail()
        {
            Console.Write("The dog is now chasing it's tail!");
        }
    }
}
