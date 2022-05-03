﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Entities
{
    public class TeamLead : Developer
    {
        public List<Developer> TeamMembers { get; set; }

        public TeamLead(int id, string firstName, string lastName, int workingHours, string currentProjectName, List<Developer> teamMembers) : base(id, firstName, lastName, workingHours, currentProjectName)
        {
            TeamMembers = teamMembers;
        }

        public override void Work()
        {
            Random random = new Random();

            Developer developer = TeamMembers[random.Next(TeamMembers.Count)];

            Console.WriteLine($"{FirstName} {LastName} is assigning work to a team member on {developer.GetInfo()}");
        }

        public override double GetSalary()
        {
            int numberOfDevelopers = TeamMembers.Count;

            if(numberOfDevelopers == 0)
            {
                numberOfDevelopers = 1;
            }

            return Salary * numberOfDevelopers;
        }
    }
}
