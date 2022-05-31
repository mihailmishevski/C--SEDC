using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileDb.Entities
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }

        public string Model { get; set; }

        [JsonConstructor]
        public Car(int id, string name, string model) : base(id)
        {
            Name = name;
            Model = model;
        }

        public Car(string name, string model) : base()
        {
            Name = name;
            Model = model;
        }
    }
}
