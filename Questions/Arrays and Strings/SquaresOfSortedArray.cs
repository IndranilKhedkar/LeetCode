using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    public class SquaresOfSortedArray : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/squares-of-a-sorted-array/
        /// Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, 
        /// also in sorted non-decreasing order.
        /// Example 1:
        ///     Input: [-4,-1,0,3,10]
        ///     Output: [0,1,9,16,100]
        /// Example 2: 
        ///     Input: [-7,-3,2,3,11]
        ///     Output: [4,9,9,49,121]
        /// </summary>
        public int[] SortedSquares(int[] A)
        {
            int len = A.Length;
            int[] result = new int[len];
            int start = 0;
            int end = len - 1;

            for (int i = len - 1; i > -1; i--)
            {
                if (Math.Abs(A[end]) > Math.Abs(A[start]))
                {
                    result[i] = A[end] * A[end];
                    end -= 1;
                }
                else
                {
                    result[i] = A[start] * A[start];
                    start += 1;
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { -4, -1, 0, 3, 10 };
            SortedSquares(input);

            // Example 2
            input = new int[] { -7, -3, 2, 3, 11 };
            SortedSquares(input);
        }
    }
}
