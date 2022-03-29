using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected double Salary { get; set; }

        public Role Role { get; set; }

        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }


}
