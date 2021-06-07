using LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
 public class QueueUsingLinkedList
    {
        LinkedList linkedList;

        public QueueUsingLinkedList()
        {
            linkedList = new LinkedList();
        }

        public void Enqueue(string data)
        {
            linkedList.Append(data);
        }

        public string Dequeue()
        {
            var message = linkedList.Head.Data;
            linkedList.Remove(0);
            return message;
        }

        public void Print()
        {
            linkedList.PrintList();
        }

    }
}
