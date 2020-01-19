using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Helpers;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/pascals-triangle/
    /// Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.
    /// Note that the row index starts from 0.
    /// In Pascal's triangle, each number is the sum of the two numbers directly above it.
    /// Example:
    ///     Input: 3
    ///     Output: [1,3,3,1]
    /// Follow up: Could you optimize your algorithm to use only O(k) extra space?
    /// </summary>
    [RelatedTopic(Topic.Array)]
    public class PascalTriangleII : Question
    {
        /// <summary>
        /// Pascal Triangle can be generated using Combinations Calculator (nCr)
        /// C(n,r)= nCr = n!/(r!(n−r)!)
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
            {
                result.Add((int)RationalMath.Combination(rowIndex, i));
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int rowIndex = 5;
            var result = GetRow(rowIndex);

            // Example 2
            rowIndex = 15;
            result = GetRow(rowIndex);

            // Example 3
            rowIndex = 21;
            result = GetRow(rowIndex);
        }
    }
}
