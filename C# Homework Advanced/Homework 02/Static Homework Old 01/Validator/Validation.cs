using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public static class Validation
    {
        public static bool Validate(Vehicle vehicle)
        {
            if(vehicle.Id != 0 && vehicle.Type != "" && vehicle.YearOfProduction != new DateOnly(1901, 01, 01))
            {
                return true;
            }

            return false;
        }
    }
}
