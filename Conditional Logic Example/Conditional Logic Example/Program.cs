using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Age cannot be negative.");
        }
        else if (age >= 0 && age <= 12)
        {
            Console.WriteLine("You are a child.");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 20 && age <= 59)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
