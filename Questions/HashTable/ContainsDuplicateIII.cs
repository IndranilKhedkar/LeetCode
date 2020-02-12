using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections;

namespace HashTable
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/contains-duplicate-iii/
    /// Given an array of integers, find out whether there are two distinct indices i and j in the array such that the absolute difference between nums[i] and nums[j] is at most t and the absolute difference between i and j is at most k.
    /// 
    /// Example 1:
    ///     Input: nums = [1,2,3,1], k = 3, t = 0
    ///     Output: true
    /// 
    /// Example 2:
    ///     Input: nums = [1,0,1,1], k = 1, t = 2
    ///     Output: true
    /// 
    /// Example 3:
    ///     Input: nums = [1,5,9,1,5,9], k = 2, t = 3
    ///     Output: false
    /// </summary>
    [RelatedTopic(Topic.OrderedMap)]
    public class ContainsDuplicateIII : Question
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            int len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < i + 1 + k && j < len; j++)
                {
                    long absNumsDiff = System.Math.Abs((long)nums[j] - (long)nums[i]);
                    if (absNumsDiff <= t)
                        return true;
                }
            }

            return false;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 2, 2 };
            int k = 3;
            int t = 0;
            var result = ContainsNearbyAlmostDuplicate(input, k, t);

            // Example 2
            input = new int[] { -1, 2147483647 };
            k = 1;
            t = 2147483647;
            result = ContainsNearbyAlmostDuplicate(input, k, t);

            //// Example 3
            //input = new int[] { 1, 2, 3, 1, 2, 3 };
            //k = 2;
            //result = ContainsNearbyDuplicate(input, k);
        }
    }
}
