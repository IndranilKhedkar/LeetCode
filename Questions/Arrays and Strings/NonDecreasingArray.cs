using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    public class NonDecreasingArray : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/non-decreasing-array/
        ///  Given an array with n integers, your task is to check if it could become non-decreasing by modifying at most 1 element.
        ///  We define an array is non-decreasing if array[i] <= array[i + 1] holds for every i(1 <= i<n). 
        /// Example 1:
        ///     Input: [4,2,3]
        ///     Output: True
        ///     Explanation: You could modify the first 4 to 1 to get a non-decreasing array.
        /// Example 2:
        ///     Input: [4,2,1]
        ///     Output: False
        ///     Explanation: You can't get a non-decreasing array by modify at most one element.
        /// </summary>
        public bool CheckPossibility(int[] nums)
        {
            bool result = true;
            int len = nums.Length;
            int descendingNumsCount = 0;

            if (len <= 1)
                return result;

            int prevMin = Math.Min(nums[0], nums[1]);
            int prevMax = Math.Max(nums[0], nums[1]);
            for (int i = 0; i < len - 1; i++)
            {
                if ((nums[i + 1] < nums[i] || (prevMin > nums[i] || prevMax < nums[i]))
                    && descendingNumsCount++ > 1)
                {
                    break;
                }

                prevMin = Math.Min(prevMin, nums[i]);
                prevMax = Math.Min(prevMax, nums[i]);
            }

            return descendingNumsCount <= 1;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 4, 2, 3 };
            bool result = CheckPossibility(input);

            // Example 2
            input = new int[] { 3, 4, 2, 3 };
            result = CheckPossibility(input);

            // Example 3
            input = new int[] { -1, 4, 2, 3 };
            result = CheckPossibility(input);

            input = new int[] { 1, 3, 5, 2, 4 };
            result = CheckPossibility(input);
        }
    }
}
