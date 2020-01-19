using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/climbing-stairs/
    /// Example 1:
    /// You are climbing a stair case. It takes n steps to reach to the top.
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// Note: Given n will be a positive integer.
    /// Example 1:
    ///     Input: 2
    ///     Output: 2
    /// Explanation: There are two ways to climb to the top.
    ///              1. 1 step + 1 step
    ///              2. 2 steps
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    public class ClimbingStairs : Question
    {
        public int ClimbStairs(int n)
        {
            if (n == 0 || n == 1)
                return n;

            int[] mem = new int[n];
            mem[0] = 1;
            mem[1] = 2;

            for (int i = 2; i < n; i++)
            {
                mem[i] = mem[i - 1] + mem[i - 2];
            }

            return mem[n - 1];
        }

        public int ClimbStairs_1(int n)
        {
            if (n == 0 || n == 1)
                return n;

            int step1 = 1;
            int step2 = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = step1 + step2;
                step2 = step1;
                step1 = result;
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: 0
            var result = ClimbStairs(0);
            result = ClimbStairs_1(0);

            // Example 2
            // Output: 1
            result = ClimbStairs(1);
            result = ClimbStairs_1(1);

            // Example 3
            // Output: 2
            result = ClimbStairs(2);
            result = ClimbStairs_1(2);

            // Example 4
            // Output: 3
            result = ClimbStairs(3);
            result = ClimbStairs_1(3);

            // Example 5
            // Output: 5
            result = ClimbStairs(4);
            result = ClimbStairs_1(4);

            // Example 6
            // Output: 8
            result = ClimbStairs(5);
            result = ClimbStairs_1(5);
        }
    }
}
