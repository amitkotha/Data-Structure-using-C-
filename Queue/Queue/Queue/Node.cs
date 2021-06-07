using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class Node
    {
        public string Data { get; set; }

        public Node Next { get; set; }

        public Node(string data)
        {
            this.Data = data;
            this.Next = null;

        }
    }
}
