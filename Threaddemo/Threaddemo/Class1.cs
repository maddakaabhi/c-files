// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
class Class1
{
    static void Test1()
    {

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Thread 1:"+i);
        }
        Thread.Sleep(3000);
    }
    static void Test2()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("thread 2:"+i);

        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Thread Main is starting");
        Thread t1 = new Thread(Test1);
        Thread t2 = new Thread(Test2);
        t1.Start(); t2.Start();
        t1.Join();t2.Join();                                //until the total process of threads executed "main thread exiting is waiting"
        Console.WriteLine("Thread Main is exiting");


    }
}

