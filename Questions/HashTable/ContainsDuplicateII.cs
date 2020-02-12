using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections;

namespace HashTable
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/single-number/
    /// Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
    /// Example 1:
    ///     Input: nums = [1,2,3,1], k = 3
    ///     Output: true
    /// 
    /// Example 2:
    ///     Input: nums = [1,0,1,1], k = 1
    ///     Output: true
    /// 
    /// Example 3:
    ///     Input: nums = [1,2,3,1,2,3], k = 2
    ///     Output: false
    /// </summary>
    [RelatedTopic(Topic.HashTable)]
    public class ContainsDuplicateII : Question
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Hashtable hashtable = new Hashtable();
            int len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if (hashtable.ContainsKey(nums[i]))
                {
                    int index = (int)hashtable[nums[i]];
                    if ((i - index) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        hashtable[nums[i]] = i;
                    }
                }
                else
                {
                    hashtable[nums[i]] = i;
                }
            }

            return false;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 1, 2, 3, 1 };
            int k = 3;
            var result = ContainsNearbyDuplicate(input, k);

            // Example 2
            input = new int[] { 1, 0, 1, 1 };
            k = 1;
            result = ContainsNearbyDuplicate(input, k);

            // Example 3
            input = new int[] { 1, 2, 3, 1, 2, 3 };
            k = 2;
            result = ContainsNearbyDuplicate(input, k);
        }
    }
}
