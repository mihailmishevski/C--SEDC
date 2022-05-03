using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehicle
    {

        public int Id { get; set; }

        public string Type { get; set; }

        public DateOnly YearOfProduction { get; set; }

        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, DateOnly yearOfProduction, int batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"{Id} {Type} {YearOfProduction}");
        }
    }
}
