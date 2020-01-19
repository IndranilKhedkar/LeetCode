using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace BitManipulation
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/single-number/
    /// Given a non-empty array of integers, every element appears twice except for one. Find that single one.
    /// Note:
    /// Your algorithm should have a linear runtime complexity.Could you implement it without using extra memory?
    /// Example 1:
    /// Input: [2,2,1]
    /// Output: 1
    /// Example 2:
    /// Input: [4,1,2,1,2]
    /// Output: 4
    /// </summary>
    [RelatedTopic(Topic.BitManipulation)]
    [RelatedTopic(Topic.HashSet)]
    public class FindSingleUniqueNumber : Question
    {
        public int SingleNumber(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 2, 2, 1 };
            var result = SingleNumber(input);

            // Example 2
            input = new int[] { 4, 1, 2, 1, 2 };
            result = SingleNumber(input);
        }
    }
}
