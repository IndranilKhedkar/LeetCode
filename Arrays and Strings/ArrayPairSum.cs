using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/array-partition-i/
    /// Given an array of 2n integers, your task is to group these integers into n pairs of integer, say (a1, b1), (a2, b2), ..., (an, bn) 
    /// which makes sum of min(ai, bi) for all i from 1 to n as large as possible. 
    /// Example 1:
    ///     Input: [1,4,3,2]
    ///     Output: 4
    ///     Explanation: n is 2, and the maximum sum of pairs is 4 = min(1, 2) + min(3, 4).
    /// Constraints: 
    ///     n is a positive integer, which is in the range of[1, 10000].
    ///     All the integers in the array will be in the range of[-10000, 10000].
    /// </summary>
    public class ArrayPairSum : Question
    {
        public int GetArrayPairMaxSum(int[] nums)
        {
            int len = nums.Length;
            int result = 0;

            Array.Sort(nums);

            for (int i = 0; i < len; i += 2)
            {
                result += Math.Min(nums[i], nums[i + 1]);
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 1, 4, 3, 2 };
            GetArrayPairMaxSum(arr);
        }
    }
}
