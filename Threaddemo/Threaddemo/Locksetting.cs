using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Threaddemo
{
    public class Locksetting
    {
        public void Test()
        {
            lock (this)
            {
                Console.WriteLine("Csharp is an ");
                Thread.Sleep(3000);
                Console.WriteLine("object oriented");
            }

        }
    
    static void Main()
        {
         Locksetting obj= new Locksetting();
         Thread t1= new Thread(obj.Test);
         Thread t2= new Thread(obj.Test);
         Thread t3= new Thread(obj.Test);
         t1.Start();t2.Start();t3.Start();
        }
    }
}
