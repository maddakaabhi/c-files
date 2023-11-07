// See https://aka.ms/new-console-template for more information
using program;
using System;
class Program:Student
{
    public static void Main(string[] args)
    {
        Program p1 = new Program();
        Console.WriteLine(p1.name);
        p1.print();

    }
}
