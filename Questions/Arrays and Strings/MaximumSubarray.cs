using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/maximum-subarray/
    /// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    /// Example:
    /// Input: [-2,1,-3,4,-1,2,1,-5,4],
    /// Output: 6
    /// Explanation: [4,-1,2,1] has the largest sum = 6.
    /// Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.DivideAndConquer)]
    [RelatedTopic(Topic.DynamicProgramming)]
    public class MaximumSubarray : Question
    {
        public int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int len = nums.Length;

            if (len == 1)
                return nums[0];

            for (int i = len - 2; i >= 0; i--)
            {
                var currVal = Math.Max(nums[i], nums[i] + nums[i + 1]);
                nums[i] = currVal;
            }

            for (int i = 0; i < len; i++)
            {
                result = Math.Max(nums[i], result);
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = MaxSubArray(arr);

            // Example 2
            arr = new int[] { -2, 1 };
            result = MaxSubArray(arr);
        }
    }
}
