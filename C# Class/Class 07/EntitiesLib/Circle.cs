using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities
{
    public class Circle : Shape
    {
        public decimal Radius { get; set; }

        public Circle(decimal radius, string color) : base(color)
        {
            Radius = radius;
        }
    }
}
