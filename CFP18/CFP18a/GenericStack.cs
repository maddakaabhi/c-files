using System;
using System.Collections.Generic;
using System.Text;

namespace CFP18a
{
    public class GenericStack
    {
        public void Test3<T>()
        {
            Stack<string> x = new Stack<string> ();
            x.Push("ab");
            x.Push("bc");
            x.Push("ca");

            foreach (string s in x)
            {
                Console.WriteLine (s);
            }
            Console.WriteLine("delting an element");
            x.Pop();
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("peek element");
            Console.WriteLine(x.Peek());
            Console.WriteLine();
            Console.WriteLine("checking an element \"bc\" is present or not");
            bool z = x.Contains("bc");
            Console.WriteLine(z);

        }

    }
}
