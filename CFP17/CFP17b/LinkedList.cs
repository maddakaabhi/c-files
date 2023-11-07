using System;
using System.Collections.Generic;
using System.Text;

namespace CFP17b
{
    public class LinkedList
    {
        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }
        public int Count
        {
            get { return this.count; }
        }
        public bool empty
        {
            get { return this.count == 0; }
        }
        public Object Add(int index, Object o)
        {
            if (index < 0) throw new ArgumentOutOfRangeException("index");
            if (index > count)
                index = count;
            Node current = this.head;
            if (index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);
            }
            count++;
            return o;

        }
        public Object Add(Object o) 
        {
            return Add(count, o);
        }

        public void Display()
        {
            Node current = this.head;
            while (current != null)
            {
                Console.Write(current.data+"->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
