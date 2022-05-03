using StaticClass_Exercise_01.Database;
using StaticClass_Exercise_01.Entities;
using StaticClass_Exercise_01.Helpers;

while (true)
{
    Console.WriteLine($"Enter {MenuOptions.PRINT_ALL_USERS} to print all users and enter {MenuOptions.REGISTER_USER} to register");
    string input = Console.ReadLine();

    if(input == MenuOptions.PRINT_ALL_USERS)
    {
        UserDatabase.USERS.ForEach(Console.WriteLine);
    }
    else if(input == MenuOptions.REGISTER_USER)
    {
        Console.WriteLine("Enter username (cannot be greater than 255 chars)");
        string username = Console.ReadLine();

        if(username.Length > User.USERNAME_MAX_LENGTH)
        {
            throw new IndexOutOfRangeException("Username is too long");
        }

        UserDatabase.USERS.Add(new User(username));
    }
}