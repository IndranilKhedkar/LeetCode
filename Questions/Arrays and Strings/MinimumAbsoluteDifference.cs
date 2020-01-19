using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    public class MinimumAbsoluteDifference : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/minimum-absolute-difference/
        /// Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements. 
        /// Return a list of pairs in ascending order(with respect to pairs), each pair[a, b] follows
        ///     a, b are from arr
        ///     a < b
        ///     b - a equals to the minimum absolute difference of any two elements in arr
        /// </summary>
        public IList<IList<int>> MinimumAbsDifference_Approach1(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int minAbsDiff = int.MaxValue;
            int len = arr.Length;
            Array.Sort(arr);

            for (int i = 1; i < len; i++)
            {
                minAbsDiff = Math.Min(Math.Abs(arr[i] - arr[i - 1]), minAbsDiff);
            }

            for (int i = 0; i < len - 1; i++)
            {
                int j = i + 1;
                while (j < len && Math.Abs(arr[i] - arr[j]) == minAbsDiff)
                {
                    result.Add(new List<int>() { arr[i], arr[j] });
                    j++;
                }
            }

            return result;
        }

        public IList<IList<int>> MinimumAbsDifference_Approach2(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int minAbsDiff = int.MaxValue;
            int len = arr.Length;

            Array.Sort(arr);

            for (int i = 1; i < len; i++)
            {
                int currMinAbsDiff = (arr[i] - arr[i - 1]);

                if (currMinAbsDiff < minAbsDiff)
                {
                    minAbsDiff = currMinAbsDiff;
                    result.Clear();
                }

                if (currMinAbsDiff == minAbsDiff)
                {
                    result.Add(new List<int>() { arr[i - 1], arr[i] });
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 4, 2, 1, 3 };
            var result = MinimumAbsDifference_Approach1(input);
            result = MinimumAbsDifference_Approach2(input);

            // Example 2
            input = new int[] { 1, 3, 6, 10, 15 };
            result = MinimumAbsDifference_Approach1(input);
            result = MinimumAbsDifference_Approach2(input);

            // Example 3
            input = new int[] { 3, 8, -10, 23, 19, -4, -14, 27 };
            result = MinimumAbsDifference_Approach1(input);
            result = MinimumAbsDifference_Approach2(input);
        }
    }
}
