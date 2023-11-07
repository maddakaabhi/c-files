using System;
using System.Collections.Generic;
using System.Text;

namespace CFP26
{
    internal class Class1
    {
        public void Test2()
        {
            string x = "Hel sor fbk snk";
            string[] arr = x.Split(" ");
            foreach (string s in arr)
                Console.WriteLine(s);
        }
    }
}
