// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, there!");
try
{
    Console.WriteLine("pls enter the first number");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("pls enter the sec number");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double sum = num1 + num2;
    Console.WriteLine($"the sum of ur input is : {sum}");
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("pls enter a valid input and try again");
}
