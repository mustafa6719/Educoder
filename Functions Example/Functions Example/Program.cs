using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = AddNumbers(num1, num2);
        Console.WriteLine("Sum: " + sum);

        int product = MultiplyNumbers(num1, num2);
        Console.WriteLine("Product: " + product);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static int AddNumbers(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    static int MultiplyNumbers(int a, int b)
    {
        int product = a * b;
        return product;
    }
}
