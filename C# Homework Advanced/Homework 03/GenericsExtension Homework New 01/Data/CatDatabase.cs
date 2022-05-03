using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CatDatabase : Database<Cat>
    {
        public CatDatabase() : base()
        {
            Seed();
        }

        private void Seed()
        {
            _pets.Add(new Cat("Macka", "Bengal", 12, 4, true));
            _pets.Add(new Cat("Kucka", "Bengal", 13, 5, true));
        }

        public void PrintCats()
        {
            PrintAll(_pets);
        }
    }
}
