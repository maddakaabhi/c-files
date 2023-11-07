using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threaddemo
{

    //Parameterized methods in thread accepting only objects
    public class Parameterized
    {
        static void Test(object max)                 //how to call method by using thread delegate
        {
            int x=Convert.ToInt32(max);            //Converting object into int
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Thread :" + i);

            }
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread t=new Thread(obj);
            t.Start(50);                           //object value is passing to method
        }

    }
}
