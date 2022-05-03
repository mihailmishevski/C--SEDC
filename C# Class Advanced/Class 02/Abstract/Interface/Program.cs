using Interface.Entities;
using Interface.Interfaces;
using Interface.Services;

Employee employee = new Employee("Mihajlo", 32);

employee.DoWork();

IWork employeeTwo = new Employee("Dzikov", 32);

employeeTwo.DoWork();

User user = new Student("Dragan", "C# Advanced");

IUserService userService = new StudentService();

userService.LogIn(user);
userService.PrintInfromation(user);

userService = new TeacherService();

userService.LogIn(user);
userService.PrintInfromation(user);