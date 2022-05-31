using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileDb.Entities
{
    public class Person : BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Car Car { get; set; }

        [JsonConstructor]
        public Person(int id, string firstName, string lastName, int age, Car car) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Car = car;
        }

        public Person(string firstName, string lastName, int age, Car car) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Car = car;
        }
    }
}
