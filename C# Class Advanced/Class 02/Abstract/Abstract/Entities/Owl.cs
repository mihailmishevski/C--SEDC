﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    internal class Owl : Bird
    {
        public Owl(string color, int flightSpeed, int height) : base(color, flightSpeed, height)
        {
        }

        public override void Sing()
        {
            Console.WriteLine("Owl is singing the owl song");
        }
    }
}
