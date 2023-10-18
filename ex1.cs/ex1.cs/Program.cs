// See https://aka.ms/new-console-template for more information
using System;
class program
{
    static void Main(string[] args)
    {
        string food1;
        string food2;
        ex(out food1, out food2);
        Console.WriteLine($"My favourite foods are {food1} and {food2}");
    }
    static void ex(out string f1, out string f2)
    {
        f1 = "Banana";
        f2 = "Mango";
    }

}
