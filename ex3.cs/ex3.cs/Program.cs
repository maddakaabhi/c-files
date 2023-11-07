// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace helo
{
    class Test
    {
        public int x;
        public Test(int x)
        {
            this.x = x;

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Test y = new Test(5);
            Console.WriteLine(y.x);
        }

    }
}
