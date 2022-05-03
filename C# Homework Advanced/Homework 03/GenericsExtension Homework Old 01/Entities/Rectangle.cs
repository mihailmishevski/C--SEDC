using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }

        public int SideB { get; set; }

        public Rectangle(int sideA, int sideB)
        {
            Id = -1;
            SideA = sideA;
            SideB = sideB;
        }

        public override int GetArea()
        {
            return SideA * SideB;
        }

        public override int GetParameter()
        {
            return SideA + SideB;
        }
    }
}
