using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName, 500, Role.Sales)
        {

        }

        public double AddSuccessRevenue(double number)
        {
            return SuccessSaleRevenue = number;
        }

        public override double GetSalary()
        {

            if(SuccessSaleRevenue <= 2000)
            {
                return 500 + Salary;
            }

            if(SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return 1000 + Salary;
            }

            if(SuccessSaleRevenue > 5000)
            {
                return 1500 + Salary;
            }

            return 0;
        }
    }
}
