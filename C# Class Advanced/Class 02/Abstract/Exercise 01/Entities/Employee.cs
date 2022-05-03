using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Entities
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int WorkingHours { get; set; }

        protected double Salary;

        public Employee(int id, string firstName, string lastName, int workingHours)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            WorkingHours = workingHours;
            Salary = 10000;
        }

        public abstract void Work();

        public abstract double GetSalary();

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} Working hours : {WorkingHours}";
        }
    }
}
