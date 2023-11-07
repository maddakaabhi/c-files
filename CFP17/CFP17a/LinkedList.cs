using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CFP17a
{
    public  class LinkedList
    {
        private Node head;
        private int count;

        public LinkedList()
        {
            this.head= null;
            this.count= 0;
        }
        public bool empty
        {
            get { return this.count == 0; } 
        }

        public int Count()
        {
            return this.count;
        }
        public object Add(int index, object o)
        {
            if ( index <0)
            {
                throw new ArgumentOutOfRangeException("index "+index);
            }
            if (index > this.count)
            {
                index = count;
            }

            Node Current = this.head;

            if ( index == 0 ) 
            {
                this.head = new Node(o, this.head);
            }
            else 
            {
                for (int i = 0; i < index - 1; i++)
                {
                    Current = Current.Next;
                }
                Current.Next = new Node(o, Current.Next);
            }
            count++;
            return o;
           
        }
        public object Add(object o)   //element inserted at the end
        {
            return Add(count, o);
        }

        public void Display()
        {
            Node current = this.head;
            while(current != null)
            {
                Console.Write(current.data+"->");
                current= current.Next;
            }
        }

        public object Remove(int index)
        {
            if ( index < 0)
            {
                throw new ArgumentOutOfRangeException("index"+index);
            }
            if (this.empty)
            {
                return null;
            }
            if (index > this.count) 
            {
                index = count-1;
            }
            Node Current = this.head;
            Object result = null;

            if ( index == 0 ) 
            {
                result = Current.data;
                this.head = Current.Next;
            }
            else
            {
                for(int i = 0;i < index - 1; i++)
                {
                    Current = Current.Next;
                }
                result = Current.Next.data;
                Current.Next = Current.Next.Next;
            }
            count--;
            return result;
        }
        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(Object o)
        {
            Node current =this.head;
            for(int i = 0; i < this.count; i++) 
            {
                if (current.data.Equals(o))
                {
                    return i;
                    
                }
                current = current.Next;

            }
            return -1;

        }
        public bool Contains(Object o)
        {
            return IndexOf(o) >= 0;
        }


    }
    
}
