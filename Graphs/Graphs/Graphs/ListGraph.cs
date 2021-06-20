using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
   public class ListGraph
    {
        private int _nodes;
        private LinkedList<Edge>[] _graph;

       public ListGraph(int nodes)
        {
            _nodes = nodes;
            _graph = new LinkedList<Edge>[_nodes];
            for(int i = 0; i < _nodes; i++)
            {
                _graph[i] = new LinkedList<Edge>();
            }
        }

        public void AddEdge(int source, int destination, int weight)
        {
            if (source > _nodes - 1 || destination > _nodes - 1 || source < 0 || destination < 0)
            {
                throw new InvalidOperationException("");
            }

            _graph[source].AddFirst(new Edge(destination, weight));
        }

        public override string ToString()
        {
            string res = string.Empty;
            for(int i = 0; i < _nodes; i++)
            {
                var c = _graph[i].First;
                res += ($"\n{i}-->");
                while (c != null)
                {
                    res += ($"{c.Value}->");
                    c = c.Next;
                }
            }
            return res;
        }
        public bool AreConnected(int source, int destination)
        {
            var c = _graph[source].First;
            while (c != null)
            {
                if (c.Value.Destination == destination)
                {
                    return true;
                }
                c = c.Next;
            }
            return false;
        }

        public int[] GetNeighbours(int node)
        {
            var res = new List<int>();
            var c = _graph[node].First;
            while (c != null)
            {
                res.Add(c.Value.Destination);
                c = c.Next;
            }
            return res.ToArray();
        }
    }

    public class Edge
    {
        public int Destination { get; set; }

        public int Weight { get; set; }

        public Edge(int destination,int weight)
        {
            Destination = destination;
            Weight = weight;

        }

        public override string ToString()
        {
            return $"({Destination}, {Weight})";
        }
    }
}
