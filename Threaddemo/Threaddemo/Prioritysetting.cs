using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threaddemo
{
    public class Prioritysetting
    {
        static long cout1, cout2;
        static void Test1()
        {

            for (int i = 0; i < 10000; i++)
            {
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
            Thread t2 = new Thread(Test2);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();


        }

    }
}
