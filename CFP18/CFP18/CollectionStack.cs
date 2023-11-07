using System;
using System.Collections;
using System.Text;

namespace CFP18
{
    public class CollectionStack
    {
        public void Test2()
        {
            Stack y = new Stack();
            y.Push(1);
            y.Push(2);
            y.Push(3);
            y.Push(4);

            foreach (var item in y)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("deleting an element");
            y.Pop();
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("checking an element");
            Console.WriteLine(y.Contains(1));
            Console.WriteLine();
            Console.WriteLine("Number of elements in stack");
            Console.WriteLine(y.Count);
        }
    }
}
