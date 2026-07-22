// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         Console.WriteLine("Start");

//         await Task.Delay(3000);

//         Console.WriteLine("Finished after 3 seconds");
//     }
// }

using System;
//using System.Threading.Tasks;

public class MyAsync
{
    public static async Task MyAsyncFunc()
    {
        Console.WriteLine("Running async function");

        await Task.Delay(3000);

        Console.WriteLine("Delay completed");
    }
}