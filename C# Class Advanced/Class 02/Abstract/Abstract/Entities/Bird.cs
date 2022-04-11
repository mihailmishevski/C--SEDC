using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    public abstract class Bird
    {
        public string Color { get; set; }

        public int FlightSpeed { get; set; }

        public int Height { get; set; }

        protected Bird(string color, int flightSpeed, int height)
        {
            Color = color;
            FlightSpeed = flightSpeed;
            Height = height;
        }

        public abstract void Sing();
    }
}
