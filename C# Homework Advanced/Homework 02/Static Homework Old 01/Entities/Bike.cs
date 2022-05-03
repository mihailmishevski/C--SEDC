using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(int id, string type, DateOnly yearOfProduction, int batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"{YearOfProduction} {Color}");
        }
    }
}
