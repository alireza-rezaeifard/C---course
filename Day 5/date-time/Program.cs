// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ClassLibrary1;

Console.WriteLine($"the time is : {DateTime.Now}");


PersianCalendar persian = new PersianCalendar();

string persian_date = persian.GetYear(DateTime.Now)+"/"+ persian.GetMonth(DateTime.Now) + "/" + persian.GetDayOfMonth(DateTime.Now);

Console.WriteLine(persian_date);


Class1 student1 = new Class1();
student1.name = "alireza";
student1.age = 23;

Console.WriteLine($"name : {student1.name}---- age : {student1.age}");