using System;
using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class QuickSort<T>
    {
        public T[] Sort(T[] arr)
        {
            int length = arr.Length;
            if (length <= 1)
            {
                return arr;
            }

            QuickSortRecursiveHelper(ref arr, 0, length - 1);

            return arr;
        }

        private void QuickSortRecursiveHelper(ref T[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(ref arr, low, high);
                QuickSortRecursiveHelper(ref arr, low, pivot - 1);
                QuickSortRecursiveHelper(ref arr, pivot + 1, high);
            }
        }

        private int Partition(ref T[] arr, int low, int high)
        {
            T pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (Comparer<T>.Default.Compare(arr[j], pivot) <= 0)
                {
                    if (++i != j)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }

            Swap(ref arr[i + 1], ref arr[high]);

            return i + 1;
        }

        private void Swap(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
