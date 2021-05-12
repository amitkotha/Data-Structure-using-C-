using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class StackArray
    {

        private int[] array { get; set; }

        private int _pointer = -1;

        public StackArray(int length)
        {
            array = new int[length];
        }    

        public void Push(int element)
        {
            _pointer++;
            if (_pointer < array.Length)
            {
                array[_pointer] = element;

            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public int Pop()
        {
            if (_pointer < 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                _pointer--;
                return array[_pointer + 1];
            }
        }

        public int Peek()
        {
            return array[_pointer];
        }

        public bool isEmpty()
        {
            return _pointer < 0;
        }

        public void Print()
        {
            if (_pointer < 0) { Console.WriteLine("Nothing to print"); }
            for(int i = 0; i <= _pointer; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
