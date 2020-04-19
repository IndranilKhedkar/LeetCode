using Algorithms.Contracts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Graphs
{
    public class GraphTraversals : Question
    {
        public class Graph
        {
            private readonly int vertices;
            private readonly List<int>[] neighbours;

            public Graph(int v)
            {
                vertices = v;
                neighbours = new List<int>[v];
                for (int i = 0; i < v; i++)
                {
                    neighbours[i] = new List<int>();
                }
            }

            public void AddEdge(int v, int w)
            {
                neighbours[v].Add(w);
            }

            public void BFS(int s)
            {
                bool[] visited = new bool[vertices];
                Queue<int> queue = new Queue<int>();
                visited[s] = true;
                queue.Enqueue(s);

                while (queue.Count != 0)
                {
                    s = queue.Dequeue();
                    Console.WriteLine("next->" + s);

                    foreach (int next in neighbours[s])
                    {
                        if (!visited[next])
                        {
                            visited[next] = true;
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            public void DFS(int s)
            {
                bool[] visited = new bool[vertices];

                Stack<int> stack = new Stack<int>();
                visited[s] = true;
                stack.Push(s);

                while (stack.Count != 0)
                {
                    s = stack.Pop();
                    Console.WriteLine("next->" + s);
                    foreach (int i in neighbours[s])
                    {
                        if (!visited[i])
                        {
                            visited[i] = true;
                            stack.Push(i);
                        }
                    }
                }
            }

            public void PrintAdjacencyMatrix()
            {
                for (int i = 0; i < vertices; i++)
                {
                    Console.Write(i + ":[");
                    string s = "";
                    foreach (var k in neighbours[i])
                    {
                        s += (k + ",");
                    }
                    s = s.Substring(0, s.Length - 1);
                    s += "]";
                    Console.Write(s);
                    Console.WriteLine();
                }
            }
        }

        public override void Run()
        {
            Graph graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            graph.PrintAdjacencyMatrix();

            Console.WriteLine("BFS traversal starting from vertex 2:");
            graph.BFS(2);
            Console.WriteLine("DFS traversal starting from vertex 2:");
            graph.DFS(2);
        }
    }
}
