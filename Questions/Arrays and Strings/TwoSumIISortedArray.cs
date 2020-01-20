using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
    /// The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.
    /// Note: Your returned answers(both index1 and index2) are not zero-based. 
    ///       You may assume that each input would have exactly one solution and you may not use the same element twice.
    /// Example:
    ///     Input: numbers = [2, 7, 11, 15], target = 9
    ///     Output: [1,2]
    ///     Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.BinarySearch)]
    [RelatedTopic(Topic.TwoPointers)]
    public class TwoSumIISortedArray : Question
    {
        /// <summary>
        /// Two-Pointer Approach
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns>Two number indexes</returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int sum = numbers[i] + numbers[j];

                if (sum == target)
                    break;
                else if (sum > target)
                    j--;
                else
                    i++;
            }

            return new int[] { i + 1, j + 1 };
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var result = TwoSum(arr, target);
        }
    }
}
