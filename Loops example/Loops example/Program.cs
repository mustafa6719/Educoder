using System;

class Program
{
    static void Main()
    {
        // For loop
        Console.WriteLine("For loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // While loop
        Console.WriteLine("While loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        // Do-while loop
        Console.WriteLine("Do-while loop:");
        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k <= 5);

        // foreach loop
        Console.WriteLine("Foreach loop:");
        string[] fruits = { "Apple", "Banana", "Orange" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
