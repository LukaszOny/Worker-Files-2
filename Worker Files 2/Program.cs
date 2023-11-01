public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Workers Files");
        Console.WriteLine("Please enter the number");
        Console.WriteLine("1.Name");
        Console.WriteLine("2.Surname");
        Console.WriteLine("3.Pesel");
        Console.WriteLine("4.Phone number");

        string choice = Console.ReadLine();

        Console.WriteLine($"You have chosen nr: {choice}");

        string Name = "Łukasz";
        string Surname = "Onyszko";
        string Pesel = "8284821818";
        string PhoneNumber = "1234567890";

        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname {Surname}");
        Console.WriteLine($"Pesel: {Pesel}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
    }
}
