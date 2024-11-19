// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, there!");

Console.WriteLine("enter the day number of the week");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

switch(DayOfWeek)
{
    case 1:
        {
            Console.WriteLine("it's Saturday");
            break;
        }
    case 2:
        {
            Console.WriteLine("it's Sunday");
            break;
        }
    case 3:
        {
            Console.WriteLine("it's Monday");
            break;
        }
    case 4:
        {
            Console.WriteLine("it's Tuesday");
            break;
        }
    case 5:
        {
            Console.WriteLine("it's Wednesday");
            break;
        }
    case 6:
        {
            Console.WriteLine("it's Thursday");
            break;
        }
    case 7:
        {
            Console.WriteLine("it's Friday");
            break;
        }
    default:
        {
            Console.WriteLine("not a valid number")
            break;
        }
}