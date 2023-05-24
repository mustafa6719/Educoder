using System;

class Program
{
    static void Main()
    {
        // Integer data type
        int age = 25;
        Console.WriteLine("Age: " + age);

        // Floating-point data types
        float weight = 65.5f;
        Console.WriteLine("Weight: " + weight);

        double height = 170.5;
        Console.WriteLine("Height: " + height);

        // Boolean data type
        bool isStudent = true;
        Console.WriteLine("Is a student? " + isStudent);

        // Character data type
        char gender = 'M';
        Console.WriteLine("Gender: " + gender);

        // String data type
        string name = "John Smith";
        Console.WriteLine("Name: " + name);

        // Array data type
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.Write("Numbers: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // DateTime data type
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Current Date: " + currentDate);

        // Enum data type
        DaysOfWeek day = DaysOfWeek.Monday;
        Console.WriteLine("Day of the week: " + day);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
