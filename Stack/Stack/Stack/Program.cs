using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Stack implementation using array*/
            StackArray stackArray = new StackArray(10);
            Console.WriteLine("Check if stack is empty : "+stackArray.isEmpty());

            stackArray.Push(1);
            stackArray.Push(2);
            stackArray.Push(3);

            stackArray.Print();

            stackArray.Pop();
            stackArray.Print();

            /*Stack Implementation using LinkedList*/

            StackLinkedList stackLinkedList = new StackLinkedList();
            Console.WriteLine("Check if stack is empty : " + stackLinkedList.isEmpty());

            stackLinkedList.Push("A");
            stackLinkedList.Push("B");
            stackLinkedList.Push("C");

            stackLinkedList.Print();

            stackLinkedList.Pop();
            stackLinkedList.Print();



        }
    }
}
