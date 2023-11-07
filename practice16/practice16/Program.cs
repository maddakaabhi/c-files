// See https://aka.ms/new-console-template for more information
using System;
class program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{a}*{i}= {a*i}");
        }
    }
}
