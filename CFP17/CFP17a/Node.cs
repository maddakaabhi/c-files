using System;
using System.Collections.Generic;
using System.Text;

namespace CFP17a
{
    public class Node
    {
        public object data {  get; set; }
        public Node Next { get; set; }

        public Node(Object value,Node Next)
        {
            this.Next = Next;
            this.data = value;
        }
    }
}
