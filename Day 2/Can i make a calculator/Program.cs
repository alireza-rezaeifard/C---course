// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, there im your calculator!");


string continueCalculation;
do
{
    Console.WriteLine("enter the first number");
    double FirstNum = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("ecnter your calculation operator like +,%,*,-");
    string op = Console.ReadLine();

    Console.WriteLine("enter the second number");
    double SecNum = Convert.ToDouble(Console.ReadLine());

    double result = 0;
    bool validOperation = true;

    if (op == "+")
    {
        result = FirstNum + SecNum;
    }
    else if (op == "-")
    {
        result = FirstNum - SecNum;
    }
    else if (op == "*")
    {
        result = FirstNum * SecNum;
    }
    else if (op == "/")
    {
        if (SecNum != 0)
            result = FirstNum / SecNum;
        else
        {
            Console.WriteLine("you cant divide a number to zero!");
            validOperation = false;
        }
    }
    else if (op == "%")
    {
        if (SecNum != 0)
            result = FirstNum % SecNum;
        else
        {
            Console.WriteLine("divide to zero is not acceptable!");
            validOperation = false;
        }
    }
    else
    {
        Console.WriteLine("your input data is not valid try again pls");
    }

    if (validOperation)
        Console.WriteLine($"your calculation result is {result}");

    Console.Write("do you want to do another calculation? (yes/no) : ");
    continueCalculation = Console.ReadLine()?.ToLower();
} while (continueCalculation == "yes");

Console.WriteLine("good bye then");

