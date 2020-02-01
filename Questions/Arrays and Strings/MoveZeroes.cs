using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/move-zeroes/
    /// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Example:
    ///     Input: [0,1,0,3,12]
    ///     ut: [1,3,12,0,0]
    /// Note:
    ///    You must do this in-place without making a copy of the array.
    ///    Minimize the total number of operations.
    /// </summary>
    public class MoveZeroes : Question
    {
        public void MoveZeroToEnd(int[] nums)
        {
            int len = nums.Length;
            int j = int.MaxValue;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 0)
                    j = Math.Min(j, i);

                if (j < i && nums[i] != 0)
                {
                    nums[j++] = nums[i];
                    nums[i] = 0;
                }
            }
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 0, 0, 0, 0, 0 };
            MoveZeroToEnd(arr);

            // Example 2
            arr = new int[] { 1, 2, 3, 4, 5 };
            MoveZeroToEnd(arr);

            // Example 3
            arr = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroToEnd(arr);

            // Example 4
            arr = new int[] { 0, 1, 0, 0, 3, 12 };
            MoveZeroToEnd(arr);

            // Example 4
            arr = new int[] { 0, 0, 1, 0, 0, 2, 0, 3 };
            MoveZeroToEnd(arr);
        }
    }
}
