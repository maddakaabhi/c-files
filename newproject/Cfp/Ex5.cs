using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    public abstract class Ex5
    {
        public abstract void Test();
    }

    public class Abstract:Ex5
    {
        public override void Test()
        {
            Console.WriteLine("Abstract method is Executed");
        }
        public static void Main(string[] args)
        {
            Abstract x= new Abstract();
            x.Test();
        }
    }
    
}
