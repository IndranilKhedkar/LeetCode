using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Helpers;
using System.Collections.Generic;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/ugly-number/
    /// Write a program to check whether a given number is an ugly number. 
    /// Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.
    /// 
    /// Example 1:
    ///     Input: 6
    ///     Output: true
    /// Explanation: 6 = 2 × 3
    /// 
    /// Example 2:
    ///     Input: 8
    ///     Output: true
    /// Explanation: 8 = 2 × 2 × 2
    /// 
    /// Example 3:
    ///     Input: 14
    ///     Output: false 
    /// Explanation: 14 is not ugly since it includes another prime factor 7.
    /// 
    /// Note:
    ///     1 is typically treated as an ugly number.
    ///     Input is within the 32-bit signed integer range: [−231,  231 − 1].
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.String)]
    public class UglyNumber : Question
    {
        public bool IsUgly(int num)
        {
            HashSet<int> uglyNoPrimeFactors = new HashSet<int>() { 2, 3, 5 };
            var primeFactors = RationalMath.PrimeFactors(num);

            return primeFactors.IsSubsetOf(uglyNoPrimeFactors);
        }

        public override void Run()
        {
            // Example 1
            int n = 6;
            var result = IsUgly(n);

            // Example 2
            n = 8;
            result = IsUgly(n);

            // Example 3
            n = 14;
            result = IsUgly(n);

            // Example 4
            n = 30;
            result = IsUgly(n);

            // Example 4
            n = 1305744254;
            result = IsUgly(n);
        }
    }
}
