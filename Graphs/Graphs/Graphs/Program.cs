using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new ListGraph(4);
            g.AddEdge(0, 1, 1);
            g.AddEdge(0, 2, 6);
            g.AddEdge(1, 3, 9);
            Console.WriteLine(g.ToString());

            Console.WriteLine($"1 and 3 are connected : {g.AreConnected(1, 3)}");
            Console.WriteLine($"2 and 3 are connected : {g.AreConnected(2, 3)}");
        }
    }
}
