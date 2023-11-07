using System;
using System.Threading;
class Hello
{
    static void test1()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("test1 "+ i);
        }
        Console.WriteLine("Thread test1 is exiting");
    }
    
    static void test2()
    {
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("Test2 "+i);
            if (i == 3)
            {
                Console.WriteLine("Thread 2 going to sleep");
                Thread.Sleep(2000);
                Console.WriteLine("Thread 2 wake up");
            }


        }
        Console.WriteLine("Thread test2 is exiting");

    }
    static void test3()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Test3 "+i);
        }
        Console.WriteLine("Thread test3 is exiting");

    }
    static void Main(string[] args)
    {
        Thread t1 = new Thread(test1);
        Thread t2 = new Thread(test2);
        Thread t3 = new Thread(test3);
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("thread main is exiting");

    }
}

   