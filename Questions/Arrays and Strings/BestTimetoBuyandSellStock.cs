using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Helpers;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// Say you have an array for which the ith element is the price of a given stock on day i.
    /// If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
    /// Note that you cannot sell a stock before you buy one.
    /// Example 1:
    ///     Input: [7,1,5,3,6,4]
    ///     Output: 5
    ///     Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    ///                  Not 7-1 = 6, as selling price needs to be larger than buying price.
    /// Example 2:
    ///     Input: [7,6,4,3,1]
    ///     Output: 0
    ///     Explanation: In this case, no transaction is done, i.e.max profit = 0.
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.DynamicProgramming)]
    public class BestTimetoBuyandSellStock : Question
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int result = 0;
            int len = prices.Length;

            for (int i = 0; i < len; i++)
            {
                minPrice = Math.Min(prices[i], minPrice);
                result = Math.Max(result, (prices[i] - minPrice));
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 7, 1, 5, 3, 6, 4 };
            var result = MaxProfit(input);

            // Example 2
            input = new int[] { 7, 6, 4, 3, 1 };
            result = MaxProfit(input);
        }
    }
}
