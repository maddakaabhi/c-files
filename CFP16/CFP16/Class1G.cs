using System;
using System.Collections.Generic;
using System.Text;

namespace CFP16
{
    internal class Class1G
    {
        public void Test<T>(T[] arr)
        {
            Console.WriteLine($"enter {typeof(T)} type of elements into array");
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i]= (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
            }

            Console.WriteLine($"elements in {typeof(T)} type array");

            foreach (T i in arr)
            {
                Console.WriteLine(i);

            }



        }
        public void Test2<T>(T[] arr) 
        {
            foreach(T i in arr)
            { Console.WriteLine(i); }
        }
    }
}
