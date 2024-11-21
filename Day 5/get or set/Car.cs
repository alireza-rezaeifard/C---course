using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_or_set
{
    class Car
    {
        private int _speed;
        private string _carName;

        public string car_name
        {
            get { return _carName; }
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new FormatException("Car name cannot be empty or whitespace.");
                    }
                    _carName = value;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int speed
        {
            get { return _speed; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new FormatException("Speed cannot be negative.");
                    }
                    else if (value < 130)
                    {
                        Console.WriteLine("This speed is not acceptable.");
                    }
                    else
                    {
                        _speed = value;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public override string ToString()
        {
            return $"Car Name: {car_name}, Speed: {speed}";
        }
    }
}
