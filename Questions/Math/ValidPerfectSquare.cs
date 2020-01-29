using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Extensions;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/valid-perfect-square/
    /// Given a positive integer num, write a function which returns True if num is a perfect square else False.
    /// Note: Do not use any built-in library function such as sqrt.
    /// Example 1:
    ///     Input: 16
    ///     Output: true
    /// Example 2:
    ///     Input: 14
    ///     Output: false
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.BinarySearch)]
    public class ValidPerfectSquare : Question
    {
        public bool IsPerfectSquare(int num)
        {
            return num.IsPerfectSquare();
        }

        public override void Run()
        {
            // Example 1
            // Output: True
            int num = 16;
            var result = IsPerfectSquare(num);

            // Example 2
            // Output: False
            num = 14;
            result = IsPerfectSquare(num);

            // Example 3
            // Output: False
            num = 2147395600;
            result = IsPerfectSquare(num);
        }
    }
}
