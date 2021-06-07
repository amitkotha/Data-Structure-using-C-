using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LinkedLists
{
   public class LinkedList
    {
        public Node Head { get; private set; }

        public Node Tail { get; private set; }

        public int Length { get; private set; }

        public void PrintList()
        {
            if (Head == null)
            {
                Debug.WriteLine("The List is empty");
            }
            else
            {
                var current = this.Head;
                while (current != null)
                {
                    Debug.WriteLine($"Current Data is {current.Data}");
                    current = current.Next;
                }
            }
        }

        public Node Append(string data)
        {
            Node n = new Node(data);
            if (Head == null)
            {
                this.Head = n;
                this.Tail = n;
            }
            else
            {
                Tail.Next = n;
                Tail = n;
            }
            Length++;
            return n;

        }

        public Node Prepend(string data)
        {
            Node n = new Node(data);
            if (Head == null)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                n.Next = Head;
                Head = n;
            }
            Length++;
            return n;
        }

        public Node Find(string data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return current;
                }
                current = current.Next;
            }
            Console.WriteLine("Not found");
            return null;
        }

        public Node Insert(Node previousNode,string data)
        {
            Node n = new Node(data);
            n.Next = previousNode.Next;
            previousNode.Next = n;

            if (n.Next == null)
            {
                Tail = n;
            }
            Length++;
            return n;
        }

        public Node Insert(int index,string data)
        {
            if (index > Length || index < 0)
            {
                return null;
            }
            if (index == 0)
            {
                Prepend(data);
            }
            int cnt = 0;
            Node current = Head;
            while (current != null&&cnt<index-1)
            {
                current = current.Next;
                cnt++;

            }
            return Insert(current, data);
        }

        public void Remove(int index)
        {
            if (index >= Length || index < 0 || Head == null)
            {
                return;
            }
            if (index == 0)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
            }
            else
            {
                var current = Head;
                int cnt = 0;
                while(current!=null && cnt < index - 1)
                {
                    current = current.Next;
                    cnt++;
                }
                current.Next = current.Next.Next;
                if (current.Next == null)
                {
                    Tail = current;
                }

            }
            Length--;
        }

        public void Reverse()
        {
            
            if (Length == 1)
            {
                return;
            }
            Node previousPointer = null;
            Node currentPointer = Head;
            Node nextPointer = null;
            Tail = currentPointer;
            while (currentPointer != null)
            {

                nextPointer = currentPointer.Next;
                currentPointer.Next = previousPointer;
                previousPointer = currentPointer;
                currentPointer = nextPointer;

            }
            Head = previousPointer;

        }
    }
}
