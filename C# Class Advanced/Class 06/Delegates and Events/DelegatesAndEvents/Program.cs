SayHelloTo method = (string personName) =>
{
    Console.WriteLine(personName);
};

DoMath doMath = (int numberOne, int numberTwo) =>
{
    return numberOne + numberTwo;
};

method.Invoke("Miki");

/*method = (string personName) => { Console.WriteLine(personName + " From Annonymous Method!"); };*/

method.Invoke("Bojan");

GreetName("Miki", method);

method = new SayHelloTo(SayHelloTo);

method("Dragan");

int result = doMath(1, 2);

Console.WriteLine(result);

doMath = (int numberOne, int numberTwo) =>
{
    return numberOne * numberTwo;
};

void GreetName(string personName, SayHelloTo method)
{
    method.Invoke(personName);
    Console.WriteLine($"{personName} has been greeted");
}

void SayHelloTo(string personName)
{
    Console.WriteLine($"Hello {personName} from actual method");
}

delegate void SayHelloTo(string personName);

delegate int DoMath(int numberOne, int numberTwo);