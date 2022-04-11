// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a date!");

string newDate = Console.ReadLine();

var parsedDate = DateTime.Parse(newDate);

List<DateTime> holidays = new List<DateTime>();

holidays.Add(DateTime.Parse("1 1 2020"));
holidays.Add(DateTime.Parse("1 7 2020"));
holidays.Add(DateTime.Parse("4 20 2020"));
holidays.Add(DateTime.Parse("5 1 2020"));
holidays.Add(DateTime.Parse("5 25 2020"));
holidays.Add(DateTime.Parse("8 3 2020"));
holidays.Add(DateTime.Parse("9 8 2020"));
holidays.Add(DateTime.Parse("10 12 2020"));
holidays.Add(DateTime.Parse("10 23 2020"));
holidays.Add(DateTime.Parse("11 8 2020"));


foreach (DateTime dayAndMonth in holidays)
{
    if (dayAndMonth.Day == parsedDate.Day && dayAndMonth.Month == parsedDate.Month)
    {
        Console.WriteLine("It's a holiday!");
        return;
    }
}

if (parsedDate.DayOfWeek == DayOfWeek.Saturday || parsedDate.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("The date you entered is the weekend!");
}
else
{
    Console.WriteLine("The date you entered is a working day :(");
}

