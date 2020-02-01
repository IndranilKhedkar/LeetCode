using Algorithms.Contracts;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/contains-duplicate/
    /// Given an array of integers, find if the array contains any duplicates.
    /// Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
    /// Example 1:
    ///     Input: [1,2,3,1]
    ///     Output: true
    /// 
    /// Example 2:
    ///     Input: [1,2,3,4]
    ///     Output: false
    /// </summary>
    public class ContainsDuplicate : Question
    {
        public bool ContainsDuplicateElement(int[] nums)
        {
            HashSet<int> uniqueElements = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueElements.Contains(nums[i]))
                    return false;
                else
                    uniqueElements.Add(nums[i]);
            }
            return true;
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 1, 4, 3, 2 };
            var result = ContainsDuplicateElement(arr);

            // Example 2
            arr = new int[] { 1, 4, 3, 2, 1 };
            result = ContainsDuplicateElement(arr);
        }
    }
}
