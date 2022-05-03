using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Homework_01.Entities
{
    public class Dog
    {
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark bark!");
        }

        public static void Validate(int id, string name, string color)
        {
            if(id > 0 && name != null && color != null && name.Length > 2)
            {
                Console.WriteLine("The dog has all the properties!");
            }
        }
    }
}
