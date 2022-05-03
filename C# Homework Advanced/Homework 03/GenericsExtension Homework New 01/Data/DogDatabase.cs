using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DogDatabase : Database<Dog>
    {
        public DogDatabase() : base()
        {
            Seed();
        }

        private void Seed()
        {
            _pets.Add(new Dog("Dzeki", "Pitbull", 21, "Krosan"));
            _pets.Add(new Dog("Dzeki", "Pitbull", 21, "Krosan"));
        }

        public void PrintDogs()
        {
            PrintAll(_pets);
        }
    }
}
