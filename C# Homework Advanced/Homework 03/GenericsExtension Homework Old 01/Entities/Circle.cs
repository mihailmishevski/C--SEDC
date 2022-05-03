using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Circle : Shape
    { 
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Id = -1;
            Radius = radius;
        }

        public override int GetArea()
        {
            return (int)(Math.PI * (Radius * Radius));
        }

        public override int GetParameter()
        {
            return (int)(2 * Math.PI * Radius);
        }
    }
}
