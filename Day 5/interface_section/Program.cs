

using interface_section;

alireza morning = new alireza();
Console.WriteLine(morning.goodmorning("alireza"));


// poly morphism
Interface1 hi = new alireza();
Console.WriteLine(hi.goodmorning("amir"));



List<person> list = new List<person>();

person p1 = new person()
{
    name = "alireza",
    age = 23
};
person p2 = new person()
{
    name = "amir",
    age = 28
};
person p3 = new person()
{
    name = "ahmad",
    age = 25
};
list.Add(p1);
list.Add(p2);
list.Add(p3);

foreach (person people in list)
{
    Console.WriteLine($"the name is : {people.name}  and he is {people.age} years old");
}



