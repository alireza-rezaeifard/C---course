// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;
using Classes;

Console.WriteLine("Hello, there!");

// Create a list to store cars
List<Car> cars = new List<Car>();
List<Person> persons = new List<Person>();

// Add car1
Car car1 = new Car
{
    CarModel = "Sedan",
    MaxCarSpeed = 200,
    CarName = "Mustang"
};
cars.Add(car1);

// Add car2
Car car2 = new Car
{
    CarModel = "Sedan",
    MaxCarSpeed = 300,
    CarName = "Lamborghini"
};
cars.Add(car2);

// Add more cars as needed
Car car3 = new Car
{
    CarModel = "SUV",
    MaxCarSpeed = 180,
    CarName = "Range Rover"
};
cars.Add(car3);

Car car4 = new Car
{
    CarModel = "SUV",
    MaxCarSpeed = 180,
    CarName = "Range Rover"
};
cars.Add(car4);

Car car5 = new Car()
{
    CarModel = "SUV",
    MaxCarSpeed = 240,
    CarName = "hundai Suntafe"
};
cars.Add(car5);


Person person1 = new Person()
{
    name = "alireza",
    age = 22,
    id = 99112520
};
persons.Add(person1);

Person person2 = new Person()
{
    name = "amir",
    age = 28,
    id = 99112538
};
persons.Add(person2);

Person person3 = new Person()
{
    name = "ahmad",
    age = 25,
    id = 99112543
};
persons.Add(person3);

Console.WriteLine("\nAll Persons:");
foreach (Person person in persons)
{
    Console.WriteLine($"person Name: {person.name}, id: {person.id}, age: {person.age} years old");
}

// Show all cars
Console.WriteLine("\nAll Cars:");
foreach (Car car in cars)
{
    Console.WriteLine($"Car Name: {car.CarName}, Model: {car.CarModel}, Max Speed: {car.MaxCarSpeed} km/h");
}


