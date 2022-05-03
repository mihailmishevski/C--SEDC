using Entities;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class VehicleDatabase
    {
        public static List<Vehicle> Vehicles { get; set; }

        static VehicleDatabase()
        {
            Vehicles = new List<Vehicle>()
            {
                new Bike(1, "Shimano", new DateOnly(1993,08,28), 123, "Black"),
                new Car(2, "Volvo", new DateOnly(2001,01,23), 1423, 50, Countries.Macedonia),
                new Vehicle(3, "Konj", new DateOnly(2931, 04, 25), 534)
            };
        }
    }
}
