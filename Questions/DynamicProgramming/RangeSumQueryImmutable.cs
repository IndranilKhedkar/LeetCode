using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/range-sum-query-immutable/
    /// Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.
    /// Example:
    ///     Given nums = [-2, 0, 3, -5, 2, -1]
    ///     sumRange(0, 2) -> 1
    ///     sumRange(2, 5) -> -1
    ///     sumRange(0, 5) -> -3
    /// Note:
    ///     You may assume that the array does not change.
    ///     There are many calls to sumRange function.
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    public class RangeSumQueryImmutable : Question
    {
        public class NumArray
        {
            private int[] _nums;

            public NumArray(int[] nums)
            {
                _nums = new int[nums.Length + 1];

                for (int i = 0; i < nums.Length; i++)
                {
                    _nums[i + 1] = _nums[i] + nums[i];
                }
            }

            public int SumRange(int i, int j)
            {
                return _nums[j + 1] - _nums[i];
            }
        }

        /**
         * Your NumArray object will be instantiated and called as such:
         * NumArray obj = new NumArray(nums);
         * int param_1 = obj.SumRange(i,j);
         */

        public override void Run()
        {
            int[] nums = new int[] { -2, 0, 3, -5, 2, -1 };
            NumArray obj = new NumArray(nums);
            var result = obj.SumRange(0, 2);
            result = obj.SumRange(2, 5);
            result = obj.SumRange(0, 5);
            result = obj.SumRange(3, 3);
        }
    }
}
