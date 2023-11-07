using System;
namespace CFP17
{
    public class LinkedList
    {
        private Node Head;

        public LinkedList() 
        {
            this.Head = null;
        }
        public void Add(int value)
        {
            Node newnode= new Node(value);
            if (this. Head == null)
            {
                this.Head = newnode;
            }
            else
            {
                Node current = this.Head;
                while ( current.Next != null ) 
                {
                    current= current.Next;
                }
                current .Next = newnode;
            }
        }
        public void Display()
        {
            Node current = this.Head;
            while ( current != null ) 
            {
                Console.Write(current.value+" ");
                current = current.Next;
            }
        }
    }
}