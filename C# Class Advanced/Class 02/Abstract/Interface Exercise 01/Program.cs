using Interface_Exercise_01.Entities;

Teacher teacherOne = new Teacher(1, "Mihajlo", "mikid996", "admin", "C# Advanced");
Teacher teacherTwo = new Teacher(2, "Bojan", "bokid998", "teacher", "C# Advanced");

Student studentOne = new Student(3, "David", "davidd999", "student", new List<int>() { 5, 5, 5 });
Student studentTwo = new Student(4, "David", "david9991", "student", new List<int>() { 6, 6, 6 });

teacherOne.PrintUser();
teacherTwo.PrintUser();

studentOne.PrintUser();
studentTwo.PrintUser();