using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{
    class students : university
    {
        private string _name;
        private int _age;
        private int _id;


        public students(string universityName, string location) : base(universityName, location)
        {
        }

        public string name 
        { get 
            { return _name; } 
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("name cannot be null or whitespace");
                    }
                    _name = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }    
        public int Age
        {
            get { return _age; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        Console.WriteLine("age cant be bellow 0 try again");
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine("i think you are to old for this make it correct");
                    }
                    else
                    {
                        _age = value;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public int Id {
            get { return _id; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        Console.WriteLine("id cannot be bellow 0");
                    }
                    _id = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {Age}, ID: {Id}";
        }
    }
}
