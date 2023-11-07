using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    internal class Ex3
    {
        public void Test()
        {
            Console.WriteLine("Method1");
        }
        public void Test(string text) 
        {
            Console.WriteLine("Method2 :" +text);
        }
        public void Test(int n,string name)
        {
            Console.WriteLine("Method3 : " +n +" "+name );
        }
        public void Test(int n, string name , double x)
        {
            Console.WriteLine("Method4 : " +n +" "+name+" "+x );
        }
        static void Main(String[] args)
        {
            Ex3 z = new Ex3();
            z.Test();
            z.Test("Hello");
            z.Test(8, "Abhi");
            z.Test(8, "Abhi", 20.56);
        }
    }
}
