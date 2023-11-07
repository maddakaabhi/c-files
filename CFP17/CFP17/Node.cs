using System;
using System.Collections.Generic;
using System.Text;

namespace CFP17
{
    public class Node
    {
        public int value {  get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            this.value = value;
            this.Next = null;
        }
    }
}
