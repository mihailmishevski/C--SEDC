using Entities;
using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee =
               {
                new Employee("Mihail", "Mishevski", 500, Entities.Enums.Role.Manager),
                new Employee("Blazho", "Razbirash", 300, Entities.Enums.Role.Sales),
                new Employee("Shopraesh", "Beti", 50, Entities.Enums.Role.Other)
               };

            Employee[] Company =
            {
                new Manager("Blazho", "Razbirash"),
                new Manager("Risto", "Razbirash"),
                new Contractor("Mihail", "Mishevski", 20, 50, new Manager ("Blazho", "Razbirash")),
                new Contractor("Liahim", "Iksvehsim", 10, 30, new Manager ("Risto", "Razbirash")),
                new SalesPerson("Yikes", "Yikes")
            };

            CEO Mihail = new CEO("Mihail", "Mishevski", employee, 30, 900);
            Mihail.AddSharesPrice(50);
            Mihail.PrintInfo();
            Console.WriteLine("His salary is " + Mihail.GetSalary());
            Mihail.PrintEmployees();
        }
    }
}

