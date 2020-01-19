using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/merge-sorted-array/
    /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    /// Note: The number of elements initialized in nums1 and nums2 are m and n respectively.
    /// You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
    /// Example:
    ///     Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3  nums2 = [2, 5, 6], n = 3
    ///     Output: [1,2,2,3,5,6]
    /// </summary>
    [RelatedTopic(Topic.Array)]
    public class MergeSortedArrays : Question
    {
        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int t = m + n - 1;
            m -= 1;
            n -= 1;

            while (t >= 0)
            {
                if (m >= 0 && (n < 0 || nums1[m] > nums2[n]))
                {
                    nums1[t] = nums1[m--];
                }
                else
                {
                    nums1[t] = nums2[n--];
                }

                t--;
            }

            return nums1;
        }

        public override void Run()
        {
            // Example 1
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;
            var result = Merge(nums1, m, nums2, n);

            // Example 2
            nums1 = new int[] { 0 };
            m = 0;
            nums2 = new int[] { 1 };
            n = 1;
            result = Merge(nums1, m, nums2, n);
        }
    }
}
