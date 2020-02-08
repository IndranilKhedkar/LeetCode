using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/min-cost-climbing-stairs/
    /// On a staircase, the i-th step has some non-negative cost cost[i] assigned (0 indexed). 
    /// Once you pay the cost, you can either climb one or two steps.You need to find minimum cost to reach the top of the floor, and you can either start from the step with index 0, or the step with index 1.
    /// Example 1:
    ///     Input: cost = [10, 15, 20]
    ///     Output: 15
    ///     Explanation: Cheapest is start on cost[1], pay that cost and go to the top.
    /// Example 2:
    ///    Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
    ///    Output: 6
    ///     Explanation: Cheapest is start on cost[0], and only step on 1s, skipping cost[3].
    /// Note: Cost will have a length in the range [2, 1000]. Every cost[i] will be an integer in the range [0, 999].
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    [RelatedTopic(Topic.Array)]
    public class MinCostClimbingStairs : Question
    {
        // Recursive
        public int MinCostClimbingStairsDP(int[] cost)
        {
            if (cost.Length == 1)
                return cost[0];
            else if (cost.Length == 2)
                return System.Math.Min(cost[0], cost[1]);
            else
            {
                int?[] cache = new int?[cost.Length + 1];
                return System.Math.Min(MinCostClimbingStairsRecursiveHelper(cost, 0, cache), MinCostClimbingStairsRecursiveHelper(cost, 1, cache));
            }
        }

        public int MinCostClimbingStairsRecursiveHelper(int[] cost, int index, int?[] cache)
        {
            if (cache[index].HasValue)
            {
                return (int)cache[index];
            }
            if (index == (cost.Length - 1))
            {
                cache[index] = cost[index];
                return (int)cache[index];
            }
            if (index == (cost.Length - 2))
            {
                cache[index] = cost[index];
                return (int)cache[index];
            }

            int minCost = cost[index] + System.Math.Min(MinCostClimbingStairsRecursiveHelper(cost, index + 1, cache),
                                                        MinCostClimbingStairsRecursiveHelper(cost, index + 2, cache));
            cache[index] = minCost;
            return minCost;
        }

        // Iterative
        public int MinCostClimbingStairsIterative(int[] cost)
        {
            int len = cost.Length;

            for (int i = 2; i < len; i++)
            {
                cost[i] += System.Math.Min(cost[i - 1], cost[i - 2]);
            }

            return System.Math.Min(cost[len - 1], cost[len - 2]);
        }

        public override void Run()
        {
            // Example 1
            // Output: true
            var result = MinCostClimbingStairsDP(new int[] { 10, 15, 20 });

            // Example 2
            // Output: false    
            result = MinCostClimbingStairsDP(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
        }
    }
}
