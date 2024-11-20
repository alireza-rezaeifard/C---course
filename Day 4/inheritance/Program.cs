// See https://aka.ms/new-console-template for more information
using inheritance;

Vehicle vehicle = new Vehicle("GenericBrand", 2020);
vehicle.DisplayInfo();

Console.WriteLine();

// Create a Car object
Car car = new Car("Ford", 2021, "Mustang", 250);
car.DisplayInfo();

Vehicle car1 = new Car(brand:"iran khodro", year:2024, model:"pars", maxSpeed:220);
car1.DisplayInfo();