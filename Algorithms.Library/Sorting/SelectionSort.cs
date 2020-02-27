using System;
using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class SelectionSort<T>
    {
        public T[] Sort(T[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (Comparer<T>.Default.Compare(arr[minimum], arr[j]) > 0)
                    {
                        minimum = j;
                    }
                }

                T temp = arr[i];
                arr[i] = arr[minimum];
                arr[minimum] = temp;
            }

            return arr;
        }
    }
}
