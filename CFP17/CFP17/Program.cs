using System;

namespace CFP17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            // Adding elements to the linked list
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            // Displaying the linked list
            Console.Write("Linked List: ");
            linkedList.Display();
        }
    }
}
