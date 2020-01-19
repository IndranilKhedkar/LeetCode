using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Extensions;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/sqrtx/
    /// Implement int sqrt(int x).
    /// Compute and return the square root of x, where x is guaranteed to be a non-negative integer.
    /// Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.
    /// Example 1:
    ///     Input: 4
    ///     Output: 2
    /// Example 2:
    ///     Input: 8
    ///     Output: 2
    ///     Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.BinarySearch)]
    public class FloorSqrt : Question
    {
        public int GetFloorSqrt(int n)
        {
            return n.FloorSqrt();
        }

        public override void Run()
        {
            // Example 1
            // Output: 2
            int n = 4;
            var result = GetFloorSqrt(n);

            // Example 2
            // Output: 3
            n = 13;
            result = GetFloorSqrt(n);

            // Example 3
            // Output: 46340
            n = 2147395600;
            result = GetFloorSqrt(n);

            // Example 4
            // Output: 2
            n = 8;
            result = GetFloorSqrt(n);

            // Example 5
            // Output: 1
            n = 1;
            result = GetFloorSqrt(n);

            // Example 6
            // Output: 0
            n = 0;
            result = GetFloorSqrt(n);
        }
    }
}
