using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    public class Car
    {

        public Driver[] Drivers { get; set; }

        public Car(Driver[] drivers)
        {
            Drivers = drivers;
        }

    }
}
