using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    internal class Methods
    {
        static int x;
        public static void Test()          //static method with void type
        {
            Console.WriteLine("Static method is executed");
        }
        public static int Test1(int x) {       //static method with return type
            return x;
        }

        public void  Test2() 
        {
            Console.WriteLine("Void method Test2 is executed");

        }
        public int Test3(int y,int z) 
        {
            return y + z;
        
        }

        static void Main()
        {
            Methods m = new Methods();
            Test();
            Console.WriteLine(Test1(10));
            m.Test2();
            Console.WriteLine(m.Test3(10, 20));
        }
    }
}
