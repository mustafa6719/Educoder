using System;

class Program
{
    static void Main()
    {
        // Creating an array of integers
        int[] numbers = new int[5];

        // Initializing array elements
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        // Accessing and printing array elements
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Creating and initializing an array in a single line
        string[] fruits = { "Apple", "Banana", "Orange" };

        // Accessing and printing array elements
        Console.WriteLine("Fruits:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
