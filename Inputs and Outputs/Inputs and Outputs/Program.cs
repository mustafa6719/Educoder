class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Input/Output program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for providing your information.");
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your age is: " + age);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}