
// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
// change the console color
Console.ForegroundColor = ConsoleColor.Blue;
// color

// it is like print in python
Console.WriteLine("this is blue CMD");
// end
int a = 81;
int b = 1381;
int c, d;
c = 45;
d = 54;

Console.WriteLine(c*d);
Console.WriteLine(a + b);

bool is_Active = true;
Console.WriteLine(is_Active);

double number = 2.789;
Console.WriteLine(number);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("this is GREEN console");

string name = "alireza";

Console.WriteLine(name);

// this is a comment
Console.WriteLine(DateTime.Now);

Console.ForegroundColor= ConsoleColor.Red;
bool e = true;
Console.WriteLine(e);

char f = 'a';
Console.WriteLine(f);

float g = 12.7f;
Console.WriteLine(g);

double h = 13.00004;
Console.WriteLine(h);

Console.WriteLine(g + h);

long i = 130000000L;
Console.WriteLine(i);


// convert data type to eachother :

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("this is Gray");

int j = 10;
Console.WriteLine(j);
float k = j;
Console.WriteLine(k);
float m = 120.453f;
int l = (int)m;
Console.WriteLine(l);

int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string




Console.ReadKey();