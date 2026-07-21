// using System;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             int a = 10;
//             int b = 0;
//             int result = a / b;
//             Console.WriteLine(result);
//         }
//         catch (DivideByZeroException ex)
//         {
//             //Console.WriteLine("Error: " + ex.Message);
//             Console.WriteLine("Error: " + ex.Message);
//         }
//         // finally
//         // {
//         //     Console.WriteLine("Program completed.");
//         // }
//     }
// }

using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] age = new int[3];
            int myage = age[4];
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("exception occured : " + ex.Message);
        }
        // finally
        // {
        //     Console.WriteLine("Program completed.");
        // }
    }
}