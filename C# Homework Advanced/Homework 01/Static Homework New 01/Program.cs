using Static_Homework_01.Database;
using Static_Homework_01.Entities;



DogShelter.shelter.Add(new Dog(1, "Dorcho", "Black"));
DogShelter.shelter.Add(new Dog(2, "Blazho", "Crveno"));

DogShelter.PrintAll();

Dog checkDog = DogShelter.shelter.First();
Dog.Validate(checkDog.Id, checkDog.Name, checkDog.Color);