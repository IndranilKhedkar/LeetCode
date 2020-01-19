using Algorithms.Contracts;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/delete-columns-to-make-sorted
    /// </summary>
    public class MinDeletionsToSortListOfStrings : Question
    {
        public int MinDeletionSize(string[] A)
        {
            int result = 0;
            int len = A.Length;

            if (len == 0)
                return result;

            int stringLength = A[0].Length;
            for (int i = 0; i < stringLength; i++)
            {
                int j = 1;
                while (j < len && A[j - 1][i] < A[j][i])
                {
                    j++;
                }

                if (j != len)
                {
                    result++;
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            string[] input = new string[] { "cba", "daf", "ghi" };
            MinDeletionSize(input);

            // Example 2
            input = new string[] { "a", "b" };
            MinDeletionSize(input);

            // Example 3
            input = new string[] { "zyx", "wvu", "tsr" };
            MinDeletionSize(input);

            // Example 4
            input = new string[] { "rrjk", "furt", "guzm" };
            MinDeletionSize(input);
        }
    }
}
