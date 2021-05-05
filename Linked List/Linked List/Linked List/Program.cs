using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append("First Node");
            linkedList.Append("Second Node");
            linkedList.PrintList();
            linkedList.Prepend("Prepend Node");
            linkedList.PrintList();
            linkedList.Insert(2, "Insert Node");
            linkedList.PrintList();
            linkedList.Remove(2);
            linkedList.PrintList();
            Console.ReadLine();
        }
    }
}
