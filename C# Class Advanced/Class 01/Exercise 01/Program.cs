// See https://aka.ms/new-console-template for more information

List<string> list = new List<string>();
string name = "";

while (name != "x")
{
    Console.WriteLine("Enter a name or press x to stop the application");
    name = Console.ReadLine();
    list.Add(name.ToLower());
}

list.Remove("x");

Console.WriteLine("Enter the text that you want to check!");
string text = Console.ReadLine();

int counter = 0;
string[] newText = text.Split(' ');

foreach (string findName in list)
{
    for(int i = 0; i < newText.Length; i++)
    {
        if(findName == newText[i])
        {
            counter++;
        }
    }
    Console.WriteLine($"The name {findName} is found {counter} times");
    counter = 0;
}



