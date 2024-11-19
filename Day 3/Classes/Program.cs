// See https://aka.ms/new-console-template for more information

using Classes;

Console.WriteLine("Hello, there!");

// Create a list to store cars
List<Car> cars = new List<Car>();

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

// Show all cars
Console.WriteLine("\nAll Cars:");
foreach (Car car in cars)
{
    Console.WriteLine($"Car Name: {car.CarName}, Model: {car.CarModel}, Max Speed: {car.MaxCarSpeed} km/h");
}
