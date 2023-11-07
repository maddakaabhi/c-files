using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp14
{
    public interface Interface1
    {
        int Test(int x, int y);
    }
    public class Interface2:Interface1 
    {
        public int Test(int x, int y) 
        {
            return x+y;
        
        }
    }
    public class Interface3 : Interface1
    {
        public int Test(int x,int y)
        {
            return x * y;
        }
    }

    public class Class1

    {
        static void Main(string[] args)
        {
            Interface2 a = new Interface2();
            Interface3 b = new Interface3();
            Console.WriteLine("The sum of two numbers is "+a.Test(5,10));
            Console.WriteLine("The product of two numbers is " + b.Test(5, 10));

        }
    }
}
