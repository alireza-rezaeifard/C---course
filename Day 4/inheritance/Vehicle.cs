using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        // Method to display vehicle info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Info: Brand = {Brand}, Year = {Year}");
        }
    }
}
