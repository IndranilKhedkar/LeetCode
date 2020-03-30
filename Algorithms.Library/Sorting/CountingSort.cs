using System;
using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class CountingSort
    {
        public int[] Sort(int[] arr, int k)
        {
            int length = arr.Length;
            int[] result = new int[length];
            int[] countArr = new int[k];

            for (int i = 0; i < length; i++)
            {
                countArr[arr[i]] += 1;
            }

            for (int i = 1; i < k; i++)
            {
                countArr[i] += countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                result[countArr[arr[i]] - 1] = arr[i];
                countArr[arr[i]] -= 1;
            }

            return result;
        }
    }
}
