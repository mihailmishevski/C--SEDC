using StaticClassAndPolymorphism.Entities;
using StaticClassAndPolymorphism.Helpers;

Console.WriteLine("Enter 1 for student login and 0 for teacher login");

string userName = Console.ReadLine();

if(userName.Length > User.USERNAME_MAX_LENGTH)
{
    Console.WriteLine($"Error, name greater than {User.USERNAME_MAX_LENGTH}");
}

int.TryParse(Console.ReadLine(), out int input);

LogIn(input);

void LogIn(int input)
{
    if (input == MenuOptions.TEACHER_LOGIN)
    {
        Console.WriteLine("Welcome teacher");
    }
    else if (input == MenuOptions.STUDENT_LOGIN)
    {
        Console.WriteLine("Welcome student");
    }
}