using System;

namespace CFP17b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList x = new LinkedList();
            x.Add(0, 10);
            x.Add(20);
            x.Add(2, 30);
            x.Add(1, 40);

            Console.WriteLine(x.Count);
            x.Display();

        }
    }
}
