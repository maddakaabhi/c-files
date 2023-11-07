using System;
using System.Collections.Generic;

namespace Collectons
{
    class Generics2<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)                   //by using T we can pass any type of data
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
    }
    class TestGenerics {              //we need to create one more class 
        static void Main(string[] args)
        {
            Generics2<int> g = new Generics2<int>();
            g.Sub(1, 2);
            g.Add(1, 2);
        }


    }
}
