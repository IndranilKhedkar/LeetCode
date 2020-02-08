using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/house-robber/
    /// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
    /// Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
    ///
    /// Example 1:
    ///     Input: [1,2,3,1]
    ///     Output: 4
    ///     Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3). Total amount you can rob = 1 + 3 = 4.
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    public class HouseRobber : Question
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            int i;

            for (i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max((nums[i] + dp[i - 2]), dp[i - 1]);
            }

            return dp[i - 1];
        }

        public override void Run()
        {
            // Example 1
            // Output: 4
            int[] input = new int[] { 1, 2, 3, 1 };
            var result = Rob(input);

            // Example 2
            // Output: 12
            input = new int[] { 2, 7, 9, 3, 1 };
            result = Rob(input);
        }
    }
}
