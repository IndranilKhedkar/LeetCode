using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Library.Sorting.Tests
{
    [TestClass]
    public class TopologicalSortTests
    {
        [TestMethod]
        public void Sort_For_IntArrayInDescendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            Dictionary<int, List<int>> input = new Dictionary<int, List<int>>
            {
                { 0, new List<int>{ } },
                { 1, new List<int>{ 0 } },
                { 2, new List<int>{ 0 } },
                { 3, new List<int>{ 1, 2 } },
                { 4, new List<int>{ 3 } }
            };

            /* Act */
            var topological = new TopologicalSort(input);

            var result = topological.Sort();
        }
    }
}
