using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections.Generic;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/happy-number/
    /// Write an algorithm to determine if a number is "happy".
    /// A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.
    /// Example: 
    ///     Input: 19
    ///     Output: true
    ///     Explanation: 
    ///         12 + 92 = 82
    ///         82 + 22 = 68
    ///         62 + 82 = 100
    ///         12 + 02 + 02 = 1
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.HashSet)]
    public class HappyNumber : Question
    {
        public bool IsHappy(int n)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (!seenNumbers.Contains(n) && n != 1)
            {
                seenNumbers.Add(n);
                n = GetDigitsSquareSum(n);
            }

            return n == 1;
        }

        private int GetDigitsSquareSum(int n)
        {
            int result = 0;
            while (n != 0)
            {
                int mod = n % 10;
                result += mod * mod;
                n /= 10;
            }
            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: true
            var result = IsHappy(19);

            // Example 1
            // Output: true
            result = IsHappy(7);
        }
    }
}
