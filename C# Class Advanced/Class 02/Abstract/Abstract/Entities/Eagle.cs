using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    internal class Eagle : Bird
    {
        public Eagle(string color, int flightSpeed, int height) : base(color, flightSpeed, height)
        {
        }

        public override void Sing()
        {
            throw new NotImplementedException();
        }
    }
}
