using System;
using System.Collections;
using System.Text;

namespace CFP18
{
    public class CollectionQueue
    {
        public void Test3()
        {
            Queue a = new Queue();
            a.Enqueue(1);
            a.Enqueue("Hello");
            a.Enqueue(3);
            a.Enqueue("hi");
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
            Console.WriteLine(a.Contains("hi"));




        }
    }
}
