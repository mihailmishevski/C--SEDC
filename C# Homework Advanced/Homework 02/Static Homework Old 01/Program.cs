using Database;
using Validator;

var database = VehicleDatabase.Vehicles;


database.ForEach(x => x.PrintVehicle());
database.ForEach(x => Console.WriteLine(Validation.Validate(x)));