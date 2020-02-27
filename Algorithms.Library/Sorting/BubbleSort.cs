using System.Collections.Generic;

namespace Algorithms.Library.Sorting
{
    public class BubbleSort<T>
    {
        public T[] SortInAscendingOrder(T[] A)
        {
            int len = A.Length;
            bool swapped = true;

            for (int pass = len - 1; pass >= 0 && swapped; pass--)
            {
                swapped = false;
                for (int i = 0; i < pass; i++)
                {
                    if (Comparer<T>.Default.Compare(A[i], A[i + 1]) > 0)
                    {
                        T temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true;
                    }
                }
            }

            return A;
        }

        public T[] SortInDescendingOrder(T[] A)
        {
            int len = A.Length;
            bool swapped = true;

            for (int pass = len - 1; pass >= 0 && swapped; pass--)
            {
                swapped = false;
                for (int i = 0; i < pass; i++)
                {
                    if (Comparer<T>.Default.Compare(A[i], A[i + 1]) < 0)
                    {
                        T temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true;
                    }
                }
            }

            return A;
        }
    }
}
