using System;
using System.Collections.Generic;
using System.Text;

namespace CFP18a
{
    public class GenericList
    {
       public void Test1()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            int[] arr = {5, 6, 7};
            Console.WriteLine("using Addrange");
            list.AddRange(arr);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("insert an element at certain index");
            list.Insert(0, 8);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Removing an element 2");
            list.RemoveAt(2);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Removing an element at certain index 1");
            list.Remove(1);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            } 
            Console.WriteLine();

            Console.WriteLine("To check whether element 5 is present or not ");
            bool x = list.Contains(5);
            Console.WriteLine(x);
            Console.WriteLine();
            list.Sort();
            Console.WriteLine("sorting a list");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }






        }
    }
}
