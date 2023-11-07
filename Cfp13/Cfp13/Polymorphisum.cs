using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public class Polymorphisum
    {
        public void Test() 
        {
            Console.WriteLine("Test method is executed ");

        }
        public void Test(int x) 
        { 
            Console.WriteLine(x);
        }
        public void Test(int x, int y)
        {
            Console.WriteLine($"{x}+{y} = {x+y} ");
        }

    }
    

    
}
