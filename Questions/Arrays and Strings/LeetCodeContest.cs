using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_and_Strings
{
    public class LeetCodeContest : Question
    {
        public int[] kWeakestRows(int[,] mat, int k)
        {
            int[] result = new int[k];
            int r = mat.GetLength(0);
            int c = mat.GetLength(1);
            int[] rowWiseSum = new int[r];

            for (int i = 0; i < r; i++)
            {
                int sum = 0;
                for (int j = 0; j < c; j++)
                {
                    sum += mat[i, j];
                }
                rowWiseSum[i] = sum;
            }

            Array.Sort<int>(rowWiseSum, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            for (int i = 0; i < k; i++)
            {
                result[i] = rowWiseSum[i];
            }

            return result;
        }


        public int MinSetSize(int[] arr)
        {
            Dictionary<int, int> numByItsCount = new Dictionary<int, int>();
            int len = arr.Length;
            int sum = 0;
            int i;

            if (len <= 1)
                return len;

            for (i = 0; i < len; i++)
            {
                if (numByItsCount.ContainsKey(arr[i]))
                {
                    numByItsCount[arr[i]] += 1;
                }
                else
                {
                    numByItsCount[arr[i]] = 1;
                }
            }

            var counts = numByItsCount.Values.ToArray();
            Array.Sort<int>(counts, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            i = 0;

            while (sum < len / 2)
            {
                sum += counts[i++];
            }

            return i;
        }

        public override void Run()
        {
            int[,] mat = new int[,]
                {
                    { 1, 1, 0, 0, 0},{1, 1, 1, 1, 0},{1, 0, 0, 0, 0},{1, 1, 0, 0, 0},{1, 1, 1, 1, 1}
                };

            var res = kWeakestRows(mat, 3);


            // Example 1
            int[] arr = new int[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 };
            var result = MinSetSize(arr);

            // Example 2
            arr = new int[] { 7, 7, 7, 7, 7, 7 };
            result = MinSetSize(arr);

            // Example 3
            arr = new int[] { 1, 9 };
            result = MinSetSize(arr);

            // Example 4
            arr = new int[] { 1000, 1000, 3, 7 };
            result = MinSetSize(arr);

            // Example 5
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            result = MinSetSize(arr);
        }
    }
}
