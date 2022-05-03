using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FishDatabase : Database<Fish>
    {
        public FishDatabase() : base()
        {
            Seed();
        }

        private void Seed()
        {
            _pets.Add(new Fish("Ribche", "Pirannha", 23, 13, "Black"));
            _pets.Add(new Fish("Ribche", "Skusha", 23, 13, "Black"));
        }

        public void PrintFish()
        {
            PrintAll(_pets);
        }
    }
}
