// See https://aka.ms/new-console-template for more information
string myname = "alireza";
Console.WriteLine($"Hello, there {myname}!");

//string[] cars ={ "207", "405", "pars", "samand" };

//foreach (string item in cars)
//{
//    Console.WriteLine(item);
//}


try
{
    Console.WriteLine("how many person u do need? :");
    int person = Convert.ToInt32(Console.ReadLine());
    string[] persons = new string[person];

    for (int i = 0; i < person; i++)
    {
        Console.WriteLine($"enter the {(i+1)} person name :");
        persons[i] = Console.ReadLine();
    }
    Console.WriteLine("The persons are:");
    foreach (string name in persons)
    {
        Console.WriteLine(name);
    }
}
catch
{
    Console.WriteLine("pls enter a valid number or name");
}
