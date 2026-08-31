using System;

class Program
{
    static unsafe void Main(string[] args)
    {
        int number = 10;

        Console.WriteLine(" Before Modification");
        Console.WriteLine("Value: " + number);

        // Getting memory address
        Console.WriteLine("Address: " + (IntPtr)(&number));

        // Creating pointer
        int* ptr = &number;

        // Modify value using pointer
        *ptr = 50;

        Console.WriteLine("\n After Modification via Pointer");
        Console.WriteLine("Value: " + number);
        Console.WriteLine("Value via pointer: " + *ptr);

        Console.WriteLine("\n Learning Complete");
    }
}