// See https://aka.ms/new-console-template for more information
using get_or_set;


string name = "alireza";
Console.WriteLine($"hello there {name}\n");
List<Car> cars_name = new List<Car>();

Console.WriteLine("how many Car you need to create ? :");
int Carnum = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < Carnum; i++)
{
    Console.WriteLine($"Enter the name of car number {i + 1}");
    string car_name = Console.ReadLine();

    Console.WriteLine($"enter the max speed of car number {i + 1}");
    int max_speed = Convert.ToInt32(Console.ReadLine());


    Car car = new Car();
    car.car_name = car_name;
    car.speed = max_speed;

    cars_name.Add(car);

}

Console.WriteLine("\nCars List:");
foreach (Car machine in cars_name)
{
    Console.WriteLine(machine);
}


Console.ReadKey();
