using Algorithms.Contracts;
using System;
using System.Collections.Generic;

namespace Graphs
{
    public class CriticalRouters : Question
    {
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public List<int> GetCriticalRouters(int numRouters, int numLinks, List<List<int>> links)
        {
            // WRITE YOUR CODE HERE
            Dictionary<int, HashSet<int>> routerMap = new Dictionary<int, HashSet<int>>();

            // Build the entire router map
            foreach (var link in links)
            {
                if (!routerMap.ContainsKey(link[0]))
                {
                    routerMap[link[0]] = new HashSet<int>();
                }
                if (!routerMap.ContainsKey(link[1]))
                {
                    routerMap[link[1]] = new HashSet<int>();
                }

                routerMap[link[0]].Add(link[1]);
                routerMap[link[1]].Add(link[0]);
            }

            Console.WriteLine("------");

            List<int> result = new List<int>();

            // Remove each router and verify is the graph is connected or not 
            // At the end include the router link back again.
            for (int i = 0; i < numRouters; i++)
            {
                HashSet<int> routerNeighbours = routerMap[i];
                int sourceRouter = 0;
                foreach (var routerNeighbour in routerNeighbours)
                {
                    routerMap[routerNeighbour].Remove(i);
                    sourceRouter = routerNeighbour;
                }

                HashSet<int> visited = new HashSet<int>();

                Dfs(routerMap, sourceRouter, visited);

                if (visited.Count != numRouters - 1)
                {
                    result.Add(i);
                }

                foreach (var routerNeighbour in routerNeighbours)
                {
                    routerMap[routerNeighbour].Add(i);
                }
            }

            return result;
        }

        public void Dfs(Dictionary<int, HashSet<int>> routerMap, int sourceRouter, HashSet<int> visited)
        {
            if (visited.Contains(sourceRouter))
            {
                return;
            }

            visited.Add(sourceRouter);

            foreach (var router in routerMap[sourceRouter])
            {
                Dfs(routerMap, router, visited);
            }
        }

        public override void Run()
        {
            var routerMap = new List<List<int>>() { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 }, new List<int> { 6, 3 } };
            var result = GetCriticalRouters(6, 5, routerMap);
        }
    }
}
