using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
namespace Threaddemo
{
    public class Threadperformance
    {
        static long cout1, cout2;
        static void Test1()
        {
            
            for (int i = 0; i < 1000; i++) {
                cout1++;
            }
            Console.WriteLine(cout1);
        }
        static void Test2()
        {

            for (int i = 0; i < 1000; i++)
            {
                cout2++;
            }
            Console.WriteLine(cout2);
        }
        static void Main()
        {
            Thread t1= new Thread(Test1);
            Thread t2= new Thread(Test2);

            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            s1.Start();
            Test1();
            Test2();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            Console.WriteLine(s1.ElapsedMilliseconds);
            Console.WriteLine(s2.ElapsedMilliseconds);
        }

    }
}
