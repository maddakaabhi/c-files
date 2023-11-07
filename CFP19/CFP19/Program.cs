using System;

namespace CFP19
{
    //public delegate void Add(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action<int,int> z = (x, y) => Console.WriteLine(x * y); 
            //z.Invoke(5, 10);
            //Lambda y = new Lambda();
            //y.Test1();

            //TestPerson y = new TestPerson();
            //y.Test2();
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);

            linkedList.Display(); // Output: 1 -> 2 -> 3 -> null

        }
    }
}
