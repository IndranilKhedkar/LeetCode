using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections.Generic;
using System.Linq;

namespace HashSet
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/intersection-of-two-arrays/
    /// Given two arrays, write a function to compute their intersection.
    /// Example 1:
    ///     Input: nums1 = [1,2,2,1], nums2 = [2,2]
    ///     Output: [2]
    /// Example 2:
    ///     Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
    ///     Output: [9,4]
    /// Note:
    ///     Each element in the result must be unique.
    ///     The result can be in any order.
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.HashSet)]
    public class IntersectionofTwoArrays : Question
    {
        // Implementation using HashSet 
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hashSetNums1 = new HashSet<int>(nums1);
            HashSet<int> hashSetNums2 = new HashSet<int>(nums2);

            return hashSetNums1.Intersect(hashSetNums2).ToArray();
        }

        public override void Run()
        {
            // Example 1
            // Output: [2]
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            var result = Intersection(nums1, nums2);

            // Example 2
            // Output: [9,4]
            nums1 = new int[] { 4, 9, 5 };
            nums2 = new int[] { 9, 4, 9, 8, 4 };
            result = Intersection(nums1, nums2);
        }
    }
}
