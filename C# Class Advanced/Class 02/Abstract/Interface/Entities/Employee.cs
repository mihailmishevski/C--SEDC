using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    public class Employee : IWork
    {
        public string Name { get; set; }

        public int WorkingHours { get; set; }

        public Employee(string name, int workingHours)
        {
            Name = name;
            WorkingHours = workingHours;
        }

        public void DoWork()
        {
            Console.WriteLine($"{Name} is doing work");
        }
    }
}
