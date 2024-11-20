using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace static__exm
{
    class Person
    {
        public string name;
        public int age;
        public int id;


        // print or create for each person that we create
        public Person()
        {
            Console.WriteLine("your information are :");
        }



        // print and create only one time 
        static Person()
        {
            Console.WriteLine("this is your Person Class :");
        }
        public Person(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, ID: {id}";
        }
    }

    static class mabaham
    {
        public static string siteurl = "mabaham";
        public static string sitename = "https://mabaham.com";

    }
}
