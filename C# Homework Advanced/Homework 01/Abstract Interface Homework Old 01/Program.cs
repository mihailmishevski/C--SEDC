using Entities;
using Interfaces;

Cat cat = new Cat("Blazho", "Crniot");
cat.Eat("Govna");

List<Animal> list = new List<Animal>()
{
    new Cat("Blazho", "Razbirash"),
    new Dog("Nekojche", "Nikojche")
};

foreach(Animal x in list)
{

    if (x.GetType() == typeof(Dog))
    {
        var animal = (Dog)x;
        animal.Bark();
    }

    if (x.GetType() == typeof(Cat))
    {
        var animal = (Cat)x;
        animal.Eat("catnip");
    }
};