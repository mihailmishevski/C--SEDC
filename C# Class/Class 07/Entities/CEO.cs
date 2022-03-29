using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CEO : Employee
    {
        public Employee[] Employee { get; set; }

        public int Shares { get; set; }

        private double SharePrices { get; set; }

        public CEO(string firstName, string lastName, Employee[] emoployeeList, int sharesCEO, double salary) : base(firstName, lastName, salary, Role.Other)
        {
            Shares = sharesCEO;
            Employee = emoployeeList;
        }

        public double AddSharesPrice(double number)
        {
            return SharePrices = number;
        }

        public void PrintEmployees()
        {
            foreach(Employee employeePrint in Employee)
            {
                Console.WriteLine($"{employeePrint.FirstName} {employeePrint.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharePrices;
        }

    }
}
