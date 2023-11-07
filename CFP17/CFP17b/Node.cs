using System;
using System.Collections.Generic;
using System.Text;

namespace CFP17b
{
    internal class Node
    {
        public Object data {  get; set; }
        public Node Next { get; set; }

        public Node( Object data,Node Next)
        {
            this.data = data;
            this.Next = Next;
        }
    }
}
