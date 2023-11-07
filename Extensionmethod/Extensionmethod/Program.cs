// See https://aka.ms/new-console-template for more information
//first create a sample class like source code it is optional
//without sourcecode also we can add extension methods
using Extensionmethod;
using System;
class Program
{
    public void Test1()
    {
        Console.WriteLine("Method 1");
    }
    public void Test2()
    {
        Console.WriteLine("Method 2");                          //this code is source code
    }
    static void Main(string[] args)
    {
        Program p= new Program();
        p.Test1();
        p.Test2();                                //calling methods through instances
        p.Test3();                                //calling extension method

        int x = 5;
        Console.WriteLine("Factorial of {0} is {1}",x,x.Factorial());   //calling int extension Method factorial

        String s = "hELLO hOw Are yoU";                      //string is sealed class

        Console.WriteLine(s.ToProper());                    //calling extension of string method
    }
}

//when creating a method static in static class is converted in to non-static method when it is bounded with source code