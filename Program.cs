using System;

namespace calculator;

public class Program
{
#pragma warning disable IDE0060 // Remove unused parameter
    public static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
    {
        Console.WriteLine("Welcome to calculator function");
        int result = functions.AddNumbers.Add(5, 7);
        Console.WriteLine($"The addition of 5 and 7 is: {result}");
    }
}
