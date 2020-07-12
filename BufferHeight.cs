using System;

public class ByDenisRafi
{
    public static void Main()
    {
        Console.Title = "BufferHeight";
        Console.WriteLine("The current buffer height is {0} rows.",
                          Console.BufferHeight);
        Console.WriteLine("The current buffer width is {0} columns.",
                          Console.BufferWidth);
        Console.ReadKey();
    }
}