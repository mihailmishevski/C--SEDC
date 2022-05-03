using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Entities
{
    public class HR : Employee
    {
        public int NumberOfRecruits { get; set; }   

        public HR(int id, string firstName, string lastName, int workingHours, int numberOfRecruits) : base(id, firstName, lastName, workingHours)
        {
            NumberOfRecruits = numberOfRecruits;
        }

        public override double GetSalary()
        {
            int numberOfRecruits = NumberOfRecruits;

            if(numberOfRecruits == 0)
            {
                numberOfRecruits = 1;
            }

            return Salary * numberOfRecruits;
        }

        public override void Work()
        {
            Console.WriteLine($"{GetInfo()} is sorting documents");
        }

        public void Recruit(Developer developer)
        {
            Console.WriteLine($"{GetInfo()} is recruiting {developer.GetInfo()}");
        }
    }
}
