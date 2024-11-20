// See https://aka.ms/new-console-template for more information


using Class_Section_s___for_loops;

try
{
    Console.WriteLine("how many person u do need? :");
    int personCount = Convert.ToInt32(Console.ReadLine());
    List<Person> persons = new List<Person>();

    for (int i = 0; i < personCount; i++)
    {
        Console.WriteLine($"Enter the name of person {i + 1}:");
        string name = Console.ReadLine();

        Console.WriteLine($"Enter the age of person {i + 1}:");
        int age = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Enter the ID of person {i + 1} : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Person person = new Person(name, age, id);
        persons.Add(person);
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nThe persons are:");
    foreach (Person person in persons)
    {
        Console.WriteLine($"Name: {person.name}, Age: {person.age}, ID: {person.id}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine("Please enter valid inputs.");
}

