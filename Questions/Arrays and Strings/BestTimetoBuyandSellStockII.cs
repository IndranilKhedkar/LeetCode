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
    /// Design an algorithm to find the maximum profit.You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
    /// Note: You may not engage in multiple transactions at the same time(i.e., you must sell the stock before you buy again).
    /// 
    /// Example 1:
    ///     Input: [7,1,5,3,6,4]
    ///     Output: 7
    ///     Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4. Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
    /// 
    /// Example 2:
    ///     Input: [1,2,3,4,5]
    ///     Output: 4
    ///     Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4. Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are engaging multiple transactions at the same time.You must sell before buying again.
    /// 
    /// Example 3:
    ///     Input: [7,6,4,3,1]
    ///     Output: 0
    ///     Explanation: In this case, no transaction is done, i.e.max profit = 0.
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.DynamicProgramming)]
    public class BestTimetoBuyandSellStockII : Question
    {
        public int MaxProfit(int[] prices)
        {
            int buyPrice = int.MaxValue;
            int result = 0;
            int len = prices.Length;

            for (int i = 0; i < len; i++)
            {
                buyPrice = Math.Min(prices[i], buyPrice);

                if (buyPrice < prices[i])
                {
                    if ((i == len - 1) || (i + 1 < len && prices[i + 1] < prices[i]))
                    {
                        result += prices[i] - buyPrice;
                        buyPrice = int.MaxValue;
                    }
                }
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

            // Example 3
            input = new int[] { 1, 2, 3, 4, 5 };
            result = MaxProfit(input);
        }
    }
}
