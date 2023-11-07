// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;

public abstract class Abstractm
{
    public void add(int x,int y)
    {
        Console.WriteLine(x + y);
    }
    public void mul(int x,int y)
    {
        Console.WriteLine(x * y);
    }
    public abstract void div(int x ,int y);
    public abstract void sub(int x, int y);

}