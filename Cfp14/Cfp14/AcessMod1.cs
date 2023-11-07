using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp14
{
    public class AcessMod1
    {
        private void Test1()
        {
            Console.WriteLine("Private Test1 is executed ");
        }
        public void Test2()
        {
            Console.WriteLine(" public Test2 is executed");
        }
        internal void Test3()
        {
            Console.WriteLine("internal Test3 is executed");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected internal Test4 is executed");
        }
        protected void Test5() 
        {
            Console.WriteLine("Protected method Test5 is executed");
        }

        static void Main(string[] args)
        {
            AcessMod1 x = new AcessMod1();
            x.Test1();
            x.Test2();
            x.Test3();
            x.Test4();
            x.Test5();
        }
    }
}
