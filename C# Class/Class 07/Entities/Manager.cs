using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName) : base(firstName, lastName, 500, Role.Manager)
        {

        }

        public double AddBonus(double bonus)
        {
            return Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Bonus + Salary;
        }
    }
}
