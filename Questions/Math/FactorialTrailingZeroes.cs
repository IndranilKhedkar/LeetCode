using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/factorial-trailing-zeroes/
    /// Given an integer n, return the number of trailing zeroes in n!.
    /// Example 1:
    ///     Input: 3
    ///     Output: 0
    ///     Explanation: 3! = 6, no trailing zero.
    /// Example 2:
    ///     Input: 5
    ///     Output: 1
    ///     Explanation: 5! = 120, one trailing zero.
    /// Note: Your solution should be in logarithmic time complexity.
    /// </summary>
    [RelatedTopic(Topic.Math)]
    public class FactorialTrailingZeroes : Question
    {
        public int TrailingZeroes(int n)
        {
            int result = 0;

            for (long i = 5; n / i >= 1; i *= 5)
            {
                result += (int)(n / i);
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: 0
            int n = 3;
            var result = TrailingZeroes(n);

            // Example 2
            // Output: 1
            n = 5;
            result = TrailingZeroes(n);

            // Example 3
            // Output: 24
            n = 100;
            result = TrailingZeroes(n);

            // Example 4
            // Output: 452137076
            n = 1808548329;
            result = TrailingZeroes(n);
        }
    }
}
