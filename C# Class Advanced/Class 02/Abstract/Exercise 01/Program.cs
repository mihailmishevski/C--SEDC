﻿using Exercise_01.Entities;

List<Developer> developers = new List<Developer>()
{
    new Developer(1, "Mihajlo", "Dimovski", 32, "FixXP"),
    new Developer(2, "Bojan", "Damcevski", 40, "ProOffice"),
    new Developer(3, "Ivan", "Dzikovski", 32, "E-Health")
};

TeamLead teamLead = new TeamLead(4, "Team", "Leader", 45, "Everywhere", developers);

Developer developer = developers.First();

developer.Work();

teamLead.Work();

HR hr = new HR(5, "Ana", "Kadrovo", 40, 2);

hr.Work();

hr.Recruit(teamLead);

int someNumber = 1;
double someDouble = (double)someNumber; // 1.00 

// downcasting
// employee -> developer > teamlead

//compile time polymorphism
List<Employee> employees = new List<Employee>()
{
    new Developer(1, "Mihaljo", "Dimovski", 32, "FitXP"),
    new Developer(2, "Bojan", "Damcevski", 40, "ProOFfice"),
    new Developer(3, "Ivan", "Dzikovski", 32, "E-Health"),
    new TeamLead(4, "Team", "Leader", 45, "Everywhere", developers)
};

Employee employeeThree = new Developer(3, "Ivan", "Dzikovski", 32, "E-Health");

// TeamLead teamLeadThree = (TeamLead)employeeThree; this will cause error

foreach (Employee employee in employees)
{
    employee.Work();

    if(employee is TeamLead)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} is a team lead");
    }

    if(employee is Developer)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} is a developer");
    }

    if(employee is HR)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} is HR");
    }
}