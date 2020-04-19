using System;
using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class TopologicalSort
    {
        private readonly Dictionary<int, List<int>> mappings;
        private readonly HashSet<int> visiting = new HashSet<int>();
        private readonly HashSet<int> visited = new HashSet<int>();
        private readonly List<int> result = new List<int>();

        public TopologicalSort(Dictionary<int, List<int>> mappings)
        {
            this.mappings = mappings;
        }

        public List<int> Sort()
        {
            foreach (var v in mappings.Keys)
            {
                DFSRecursiveHelper(v);
            }

            return result;
        }

        private void DFSRecursiveHelper(int v)
        {
            if (visited.Contains(v))
            {
                return;
            }

            visiting.Add(v);

            foreach (var neighbour in mappings[v])
            {
                if (visiting.Contains(neighbour))
                {
                    throw new Exception("Circular dependecy detected");
                }
                if (!visited.Contains(neighbour))
                {
                    DFSRecursiveHelper(neighbour);
                }
            }

            visiting.Remove(v);
            visited.Add(v);
            result.Add(v);
        }
    }
}
