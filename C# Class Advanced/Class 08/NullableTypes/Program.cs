int? number = null;

if(number == null)
{
    number = 0;
    Console.WriteLine(number);
}

decimal? decimalNumber = null;

Item item = null;

Console.WriteLine($"{item.ToString().Length}");

public class Item
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }


    public int GetNameLength()
    {
        return Name?.Length ?? 0;
    }

    public override string ToString()
    {
        return Name;
    }
}