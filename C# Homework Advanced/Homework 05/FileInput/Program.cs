string currentDirectory = Directory.GetCurrentDirectory();
string newDirectory = currentDirectory + @"\Exercise";
bool ifExists = Directory.Exists(newDirectory);

if (!Directory.Exists(newDirectory))
{
    Directory.CreateDirectory(newDirectory);
}

string newFile = newDirectory + @"\calculations.txt";

if (!File.Exists(newFile))
{
    File.Create(newFile);
}

string Calculate(int a, int b)
{
    return $"{a} + {b} = {a + b}";
}

string results;

using (StreamWriter sw = new StreamWriter(newFile))
{
    int x = 0;

    while(x < 3)
    {
        Console.WriteLine("Enter two numbers to calculate");
        string numberA = Console.ReadLine();
        string numberB = Console.ReadLine();
        sw.WriteLine(Calculate(int.Parse(numberA), int.Parse(numberB)) + " " + DateTime.Now);
        x++;
    }
    sw.Flush();
    x = 0;
}

using (StreamReader sr = new StreamReader(newFile))
{
    results = sr.ReadToEnd();
}

Console.WriteLine(results);

