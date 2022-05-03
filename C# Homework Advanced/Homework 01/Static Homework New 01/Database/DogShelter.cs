using Static_Homework_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Homework_01.Database
{
    public static class DogShelter
    {
        public static List<Dog> shelter = new List<Dog>();

        public static void PrintAll()
        {
            shelter.ForEach(x => Console.WriteLine(x.Id + " " + x.Name + x.Color));
        }
    }
}
