using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Car : Vehicle
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string brand, int year, string model, int maxSpeed)
            : base(brand, year) // Call the base class constructor
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        // Override the DisplayInfo method to include car-specific details
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class version
            Console.WriteLine($"Car Details: Model = {Model}, Max Speed = {MaxSpeed} km/h");
        }
    }
}
