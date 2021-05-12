using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
  public  class Node
    {

        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string _data)
        {
            Data = _data;
            Next = null;
        }
    }
}
