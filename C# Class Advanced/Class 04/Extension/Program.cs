using Extension.Utils;

string value = " ";

if (value.isEmpty())
{
    Console.WriteLine("String is empty");
}
else
{
    Console.WriteLine($"String value is {value}");
}

int numberOne = 10;
int numberTwo = 5;

if (numberOne.IsBiggerThan(numberTwo))
{
    Console.WriteLine($"{numberOne} is bigger than {numberTwo}");
}
else
{
    Console.WriteLine($"{numberTwo} is bigger than {numberOne}");
}

decimal decimalNumber = 100.124124m;

Console.WriteLine(decimalNumber.RoundNumber()); ;