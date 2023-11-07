using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threaddemo
{
    class Nonparameterized
    {
        static void Test()                 //how to call method by using thread delegate
        {
            for(int i = 0; i < 100; i++) {
                Console.WriteLine("Thread :" + i);

            }
        }
        static void Main()
        {
            //ThreadStart obj=new ThreadStart(Test);     //Threadstart is a delegate (safe function pointer) calling method
            //ThreadStart obj = Test;                     //one more method
            //ThreadStart obj = delegate () { Test(); };  //one more method
            ThreadStart obj = () => Test();               //one more method

            Thread t =new Thread(obj);                 //passing delegate object to thread instance
            t.Start();
        }
    }
}
