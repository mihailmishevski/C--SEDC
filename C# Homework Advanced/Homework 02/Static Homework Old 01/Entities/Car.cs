using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }

        public Countries CountriesProduced { get; set; }

        public Car(int id, string type, DateOnly yearOfProduction, int batchNumber, int fuelTank, Countries countriesProduced) : base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            CountriesProduced = countriesProduced;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"{Type} {CountriesProduced}");
        }
    }
}
