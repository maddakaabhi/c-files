// See https://aka.ms/new-console-template for more information
using System;
class Matrix : Object  //(default parent class)
{
    int a, b, c, d;
    public Matrix(int a, int b, int c, int d)
    {
        this.a = a; this.b = b; this.c = c; this.d = d;
    }
    public override string ToString()
    {
        return a + " " + b + "\n" + c + " " + d + "\n";
    }



    public static Matrix operator +(Matrix obj1 , Matrix obj2)
    {
        Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
        return obj;
    }
    static void Main()
    {
        Matrix m1 = new Matrix(20, 30, 40, 50);
        Matrix m2 = new Matrix(50, 30, 20, 10);
        Matrix m3=m1+ m2;
        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine(m3);
        Console.WriteLine();

    }
}
