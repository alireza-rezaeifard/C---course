// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();
sayfuckyou();

static void sayfuckyou()
{
    string badword = fuck("fuck", "you");
    Console.WriteLine(badword);
    int thresum = threesum(60, 1, 8);
    Console.WriteLine(thresum);
    
}

static string fuck(string name, string badword)
{
    return name + " " + badword;
}

static int threesum(int x, int y, int z)
{
    return x + y + z;
}