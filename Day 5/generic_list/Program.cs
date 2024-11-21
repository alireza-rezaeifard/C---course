// See https://aka.ms/new-console-template for more information
using ConsoleTables;
using generic_list;


Console.WriteLine("Enter the university name:");
string uniName = Console.ReadLine();

Console.WriteLine("Enter the location of the university:");
string location_s = Console.ReadLine();


List<students> student_list = new List<students>();

Console.WriteLine("how many studen's you want to create");
int counts_name = Convert.ToInt32( Console.ReadLine() );

for ( int i = 0; i < counts_name; i++ )
{
    Console.WriteLine($"enter the {i + 1} name :\n ");
    string student_name = Console.ReadLine();

    Console.WriteLine($"enter the age of student : \n");
    int student_age = Convert.ToInt32( Console.ReadLine());

    Console.WriteLine($"enter the id of student {i + 1} : \n");
    int student_id = Convert.ToInt32( Console.ReadLine() );

    students student = new students(uniName, location_s)
    {
        name = student_name,
        Age = student_age,
        Id = student_id
    };
    student_list.Add(student);

}


Console.WriteLine("\nUniversity Information:");
Console.WriteLine($"University Name: {uniName}, City: {location_s}\n");

// Create a table
var table = new ConsoleTable("Name", "Age", "ID", "University", "Location");

// Add student data to the table
foreach (students item in student_list)
{
    table.AddRow(item.name, item.Age, item.Id, item.UniversityName, item.Location);
}

// Display the table
Console.WriteLine("Your list of members is:\n");
table.Write();

Console.ReadKey();  