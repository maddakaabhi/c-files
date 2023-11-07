// See https://aka.ms/new-console-template for more information
using System;
class program
{
    public void test()
    {
        Console.WriteLine("1st method");
    }
    public void test(int i)
    {
        Console.WriteLine("2nd method");
    }
    public void test(string i)
    {
        Console.WriteLine("3rd method");
    }
    public void test(int x, string y)
    {
        Console.WriteLine("4th method");
    }
    static void Main(string[] args)
    {
        program p = new program();
        p.test();
        p.test(5);
        p.test("hello");
        p.test(6, "hi");
    }
}
