using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DatabaseAcess
    {
        public static DogDatabase dogs = new DogDatabase();

        public static CatDatabase cats = new CatDatabase();

        public static FishDatabase fish = new FishDatabase();
    }
}
