using System;
using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class InsertionSort<T>
    {
        public T[] Sort(T[] arr)
        {
            int length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                T item = arr[i];
                int j = i;

                while (j >= 1 && Comparer<T>.Default.Compare(arr[j - 1], item) > 0)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = item;
            }

            return arr;
        }
    }
}
