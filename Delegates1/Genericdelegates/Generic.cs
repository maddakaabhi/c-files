// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.CompilerServices;

class Generic
{
    public static double add1(double x,double y)     //returning a value method
    {
        return x + y;
    }
    public static void Add2(int x,int y)           //non-returning a value method 
    {
        Console.WriteLine(x + y);
    }
    public  void Add3(int x, int y)           //non-returning a value method 
    {
        Console.WriteLine(x + y);
    }
    public static bool checklength(string x)       //return bool value
    {
        if (x.Length > 5)
            return true;
        return false;
    }
    static void Main(string[] args)
    {
        Generic e= new Generic();
        Func<double, double, double> a = add1;     //func generic delegate for returning methods (static method)
        Console.WriteLine(a.Invoke(5.2, 5.3));

        Action<int, int> b = Add2;                 //action delegate for non-returning method (static method)
        b.Invoke(5, 3);

        Action<int, int> c = e.Add3;                 //action delegate for non-returning method (non-static method)
        b.Invoke(5, 3);

        Predicate<string> d = checklength;          //Predicate delegate for boolean returning method (static method)
        Console.WriteLine(d.Invoke("Hello world"));


    }
}