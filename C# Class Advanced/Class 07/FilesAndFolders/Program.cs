using System.Text;

string myDirectory = @"..\..\MyDirectory";

if (!Directory.Exists(myDirectory))
{
    Directory.CreateDirectory(myDirectory);
}

string membersFilePath = $@"{myDirectory}\members.txt";

while (true)
{
    if (!File.Exists(membersFilePath))
    {
        using FileStream fs = File.Create(membersFilePath);
        fs.Write(Encoding.ASCII.GetBytes("Nikola;21;Budimpesta"));
        fs.Close();
    }
    else
    {
        string content = File.ReadAllText(membersFilePath);
        Console.WriteLine(content);

        Console.WriteLine("Enter a new member");
        string memberInfo = Console.ReadLine();

        File.AppendAllText(membersFilePath, memberInfo);
    }
}