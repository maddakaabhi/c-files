using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CFP18a
{
    public class GenericQueue
    {
        public void Test3<T>()
        {
            Queue<int> a = new Queue<int>();
            a.Enqueue(1);
            a.Enqueue(8);
            a.Enqueue(3);
            a.Enqueue(9);
            a.Enqueue(5);
            Console.WriteLine("elements in Queue");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("deleting an element");
            a.Dequeue();
            Console.WriteLine("elements in Queue");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("peek element in queue");
            Console.WriteLine(a.Peek());

            Console.WriteLine();
            Console.WriteLine("checking whether an element is present or not");
            Console.WriteLine(a.Contains(8));




        }
    }
}
