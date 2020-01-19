using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Helpers;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/pascals-triangle/
    /// Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
    /// In Pascal's triangle, each number is the sum of the two numbers directly above it.
    /// </summary>
    [RelatedTopic(Topic.Array)]
    public class PascalTriangle : Question
    {
        /// <summary>
        /// Pascal Triangle can be generated using Combinations Calculator (nCr)
        /// C(n,r)= nCr = n!/(r!(n−r)!)
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> prevRow = null;

            for (int i = 0; i < numRows; i++)
            {
                List<int> currRow = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        currRow.Add(1);
                    }
                    else
                    {
                        currRow.Add(prevRow[j] + prevRow[j - 1]);
                    }
                }

                result.Add(currRow);
                prevRow = currRow;
            }

            return result;
        }

        public IList<IList<int>> Generate_WithCombinationFormula(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> currRow = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    currRow.Add((int)RationalMath.Combination(i, j));
                }

                result.Add(currRow);
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int numRows = 5;
            var result = Generate(numRows);
            result = Generate_WithCombinationFormula(numRows);

            // Example 2
            numRows = 1;
            result = Generate(numRows);
            result = Generate_WithCombinationFormula(numRows);
        }
    }
}
