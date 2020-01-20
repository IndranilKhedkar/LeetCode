using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/majority-element/
    /// Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
    /// You may assume that the array is non-empty and the majority element always exist in the array.
    /// Example 1:
    ///     Input: [3,2,3]
    ///     Output: 3
    /// Example 2:
    ///     Input: [2,2,1,1,1,2,2]
    ///     Output: 2
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.HashTable)]
    [RelatedTopic(Topic.BoyerMooreVotingAlgorithm)]
    public class MajorityElement : Question
    {
        public int GetMajorityElement(int[] nums)
        {
            int len = nums.Length;
            int item = 0;
            int itemCount = 0;

            for (int i = 0; i < len; i++)
            {
                if (itemCount == 0)
                {
                    item = nums[i];
                }

                itemCount += (item == nums[i]) ? 1 : -1;
            }

            return item;
        }

        public int GetMajorityElementUsingHashTable(int[] nums)
        {
            int len = nums.Length;
            Hashtable hashtable = new Hashtable();
            int halfNums = len / 2;

            for (int i = 0; i < len; i++)
            {
                if (hashtable.ContainsKey(nums[i]))
                {
                    hashtable[nums[i]] = (int)hashtable[nums[i]] + 1;
                    if ((int)(hashtable[nums[i]]) > halfNums)
                        return nums[i];
                }
                else
                {
                    hashtable[nums[i]] = 1;
                }
            }

            return nums[len - 1];
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 3, 2, 3 };
            GetMajorityElement(input);

            // Example 2
            input = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            GetMajorityElement(input);
        }
    }
}
