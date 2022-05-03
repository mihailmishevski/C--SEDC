using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class Database<T> where T : Pet
    {
        protected List<T> _pets;

        public Database()
        {
            _pets = new List<T>();
        }

        public void PrintAll(List<T> pets)
        {
            pets.ForEach(x => Console.WriteLine(x.Name));
        }

        public void BuyPet(string buyPet)
        {
            var boughtPet = _pets.FirstOrDefault(x => x.Name == buyPet);

            if (boughtPet == null)
            {
                Console.WriteLine("A pet with that name doesn't exist!");
            }

            _pets.Remove(boughtPet);
        }
    }
}
