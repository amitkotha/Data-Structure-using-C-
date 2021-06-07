using System;
using System.Diagnostics;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingArray arr = new QueueUsingArray();
            arr.Enqueue("A1");
            arr.Enqueue("A2");

            arr.Print();
            Debug.WriteLine("Dequeue");
            Debug.WriteLine(arr.Dequeue());
            arr.Print();

            Console.ReadLine();

            QueueUsingLinkedList queue = new QueueUsingLinkedList();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Print();
            Debug.WriteLine("Dequeue");
            Debug.WriteLine(queue.Dequeue());
            Debug.WriteLine("Print");
            queue.Print();
            Console.ReadLine();
        }
    }
}
