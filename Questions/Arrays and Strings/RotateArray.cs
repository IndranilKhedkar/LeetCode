using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/rotate-array/
    /// Given an array, rotate the array to the right by k steps, where k is non-negative.
    /// Example 1:
    ///     Input: [1,2,3,4,5,6,7] and k = 3
    ///     Output: [5,6,7,1,2,3,4]
    ///     Explanation:                     [1,2,3,4,5,6,7]
    ///         rotate 1 steps to the right: [7,1,2,3,4,5,6]
    ///         rotate 2 steps to the right: [6,7,1,2,3,4,5]
    ///         rotate 3 steps to the right: [5,6,7,1,2,3,4]
    /// </summary>
    public class RotateArray : Question
    {
        public void RotateWithAdditionalMemory(int[] nums, int k)
        {
            int len = nums.Length;

            if (k == 0 || k == len || len < 2)
                return;

            int[] result = new int[len];

            for (int i = 0; i < len; i++)
            {
                int index = (i + k) % len;
                result[index] = nums[i];
            }

            for (int i = 0; i < len; i++)
            {
                nums[i] = result[i];
            }
        }

        public void RotateGreedy(int[] nums, int k)
        {
            int len = nums.Length;

            if (k == 0 || k == len || len < 2)
                return;

            for (int i = 0; i < k; i++)
            {
                int lastElem = nums[len - 1];
                for (int j = len - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = lastElem;
            }
        }

        public override void Run()
        {
            // Example 1
            // Output: [5,6,7,1,2,3,4]
            int k = 3;
            RotateGreedy(new int[] { 1, 2, 3, 4, 5, 6, 7 }, k);
            RotateWithAdditionalMemory(new int[] { 1, 2, 3, 4, 5, 6, 7 }, k);

            // Example 2
            // Output: [2, 1]
            k = 1;
            RotateGreedy(new int[] { 1, 2 }, k);
            RotateWithAdditionalMemory(new int[] { 1, 2 }, k);

            // Example 3
            // Output: [3,99,-1,-100]
            k = 2;
            RotateGreedy(new int[] { -1, -100, 3, 99 }, k);
            RotateWithAdditionalMemory(new int[] { -1, -100, 3, 99 }, k);
        }
    }
}
