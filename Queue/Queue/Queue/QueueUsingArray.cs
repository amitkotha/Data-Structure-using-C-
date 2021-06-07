using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Queue
{
   public class QueueUsingArray
    {
         int _front;
         int _end;
         string[] arr;

        public QueueUsingArray()
        {
            _front = _end = -1;
            arr = new string[5];
        }

        
        public bool isFull
        {
            get
            {
                return (_end + 1) % arr.Length == _front;
            }
        }

        public bool isEmpty
        {
            get
            {
                return (_front == -1) && (_end == -1);
            }
        }

        public void Enqueue(string message)
        {
            if (isFull)
            {
                Console.WriteLine("It is already full");
                return;
            }

            if (isEmpty)
            {
                _front = _end = 0;
                
            }

            else
            {
                _end = (_end + 1) % arr.Length;
            }
            arr[_end] = message;

        }

        public string Dequeue()
        {
            if (isEmpty)
            {
                Console.WriteLine("Nothing to pull");
                return null;
            }

            string res = arr[_front];

            if (_front == _end)
            {
                _front = _end = -1;
            }
            else
            {
                _front = (_front + 1) % arr.Length;
            }
            return res;
        }

        public void Print()
        {
            for (int i = _front; i <= _end; i++)
            {
                Debug.WriteLine(arr[i]);
            }
        }
    }
}
