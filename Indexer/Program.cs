﻿namespace Entity ;
class Program
{
    public static void Main(string [] args)
    {
        StudentCollection students = new StudentCollection();
        Console.WriteLine(students[3]);

        students[3]=new Student{Id= 21 , Name="krish"};
        Console.WriteLine(students[3]);
    }
}