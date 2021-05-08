using Linked_List;
using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node("Loop Node");
            LinkedList linkedList = new LinkedList();

            Console.WriteLine("Adding the First Node");
            linkedList.Append("First Node");

            Console.WriteLine("Adding the Second Node");
            linkedList.Append("Second Node");

            Node find = linkedList.Find("Second Node");
            
            linkedList.Append("Third Node");
            linkedList.PrintList();

            

            DetectLoop detectLoop = new DetectLoop();
            Console.WriteLine(detectLoop.LoopCount(linkedList));
            
            Console.ReadLine();


            Console.WriteLine("Testing the Reverse Linked List functionality");
            linkedList.Reverse();
            linkedList.PrintList();

        }
    }
}
