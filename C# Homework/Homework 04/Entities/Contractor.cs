using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Contractor : Employee
    {
        Manager Responsible { get; set; }

        public int PayPerHour { get; set; }

        public double WorkHours { get; set; }

        public Contractor(string firstName, string lastName, int payPerHourContract, double workHoursContract, Manager responsibleM) : base(firstName, lastName, 0, Role.Other)
        {
            PayPerHour = payPerHourContract;
            WorkHours = workHoursContract;
            Responsible = responsibleM;
            Salary = GetSalary();
        }

        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }

        public Manager CurrentPosition()
        {
            return Responsible;
        }

    }
}
