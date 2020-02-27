using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class MergeSort<T>
    {
        public T[] Sort(T[] arr)
        {
            MergeSortRecursiveHelper(arr, 0, arr.Length - 1);
            return arr;
        }

        private void MergeSortRecursiveHelper(T[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSortRecursiveHelper(arr, start, mid);
                MergeSortRecursiveHelper(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        private void Merge(T[] arr, int start, int mid, int end)
        {
            T[] tempArr = new T[end - start + 1];
            int k = 0;
            int p = start;
            int q = mid + 1;

            for (int i = start; i <= end; i++)
            {
                if (p > mid)
                {
                    tempArr[k++] = arr[q++];
                }
                else if (q > end)
                {
                    tempArr[k++] = arr[p++];
                }
                else if (Comparer<T>.Default.Compare(arr[p], arr[q]) > 0)
                {
                    tempArr[k++] = arr[q++];
                }
                else
                {
                    tempArr[k++] = arr[p++];
                }
            }

            for (int i = 0; i < k; i++)
            {
                arr[start++] = tempArr[i];
            }
        }
    }
}
