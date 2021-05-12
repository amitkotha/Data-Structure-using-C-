using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackLinkedList
    {
        private LinkedList _list;
        public int Length { get { return _list.Length; } }

        public StackLinkedList()
        {
            _list = new LinkedList();
        }

        public void Push(string data)
        {
            _list.Prepend(data);
        }

        public string Pop()
        {
            if (_list.Head == null)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            else
            {
                string result = _list.Head.Data;
                _list.Remove(0);
                return result;
            }
        }

        public string Peek()
        {
            return _list.Head.Data;
        }

        public bool isEmpty()
        {
             return _list.Length <= 0; 
        }

        public void Print()
        {
            _list.PrintList();
        }

    }
}
