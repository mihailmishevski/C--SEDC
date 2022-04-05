using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string BrandName { get; set; }
        
        public string ModelName { get; set; }

        public Color Color { get; set; }

        public int Distance { get; set; }

        public DateTime DateOfModel { get; set; }

        public Car(int id, string brandName, string modelName, Color color, int distance, DateTime dateOfModelCar)
        {
            Id = id;
            BrandName = brandName;
            ModelName = modelName;
            Color = color;
            Distance = distance;
            DateOfModel = dateOfModelCar;
        }

        public int CalculatePrice()
        {
            return -(DateOfModel.Year * Distance) / 3;
        }
    }
}
