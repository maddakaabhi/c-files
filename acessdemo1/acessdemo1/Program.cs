// See https://aka.ms/new-console-template for more information)
using System;
namespace acessdemo1
{
    public class Program
    {
        public void test1()
        {
            Console.WriteLine("Test1 is executed");
        }
        private void test2()
        {
            Console.WriteLine("Test2 is executed");
        }
        protected void test3()
        {
            Console.WriteLine("test3 is executed");
        }
        internal void test4()
        {
            Console.WriteLine("test4 is executed");
        }
        protected internal void test5()
        {
            Console.WriteLine("test5 is executed");
        }
        static void Main(string[] args)
        {
            Program x = new Program();
            x.test1();
            x.test2();
            x.test3();
            x.test4();
            x.test5();
        }

    }
}
