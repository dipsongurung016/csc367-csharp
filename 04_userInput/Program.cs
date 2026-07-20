using System;

class Program
{
    static void Main()
    {
        // Read a string from user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Read an integer from user input
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Read a double from user input
        Console.Write("Enter your height (in meters): ");
        double height = double.Parse(Console.ReadLine());

        // Display the input values
        Console.WriteLine("\n--- User Information ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height} meters");
    }
}


// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("what is your name?");
//         string name = Console.ReadLine();
//         Console.WriteLine("your name is " + name);
//     }
// }
