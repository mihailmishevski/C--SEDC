using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Entities
{
    public class Developer : Employee
    {
        public string CurrentProjectName { get; set; }

        public Developer(int id, string firstName, string lastName, int workingHours, string currentProjectName) : base(id, firstName, lastName, workingHours)
        {
            CurrentProjectName = currentProjectName;
        }

        public override double GetSalary()
        {
            return Salary * WorkingHours;
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} is writing code in {CurrentProjectName}");
        }
    }
}
