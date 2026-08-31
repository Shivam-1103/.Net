using System;

class Program
{
    static unsafe void Main()
    {
        int[] number = {100,101,103};

        Console.WriteLine("Before fixed block");
        Console.WriteLine("Value : " + number);

        fixed (int* ptr = number)
        {
            Console.WriteLine("\nInside fixed block");

            Console.WriteLine("Address : " + (IntPtr)ptr);
            Console.WriteLine("Value : " + *ptr);

            *ptr = 500;

            Console.WriteLine("Modified Value : " + *ptr);
        }

        Console.WriteLine("\nAfter fixed block");
        Console.WriteLine("Value : " + number);
    }
}