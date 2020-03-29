using Algorithms.Contracts;
using System;

namespace DivideAndConquer
{
    public class KClosestPointstoOrigin : Question
    {
        public int[][] KClosest(int[][] points, int K)
        {
            SortByDistanceToOriginRecursiveHelper(points, 0, points.Length - 1);
            int[][] result = new int[K][];
            for (int i = 0; i < K; i++)
            {
                result[i] = points[i];
            }
            return result;
        }

        private void SortByDistanceToOriginRecursiveHelper(int[][] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                SortByDistanceToOriginRecursiveHelper(arr, start, mid);
                SortByDistanceToOriginRecursiveHelper(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        private void Merge(int[][] arr, int start, int mid, int end)
        {
            int[][] tempArr = new int[end - start + 1][];
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
                else if (GetDistanceFromOrigin(arr[p]) > GetDistanceFromOrigin(arr[q]))
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

        private double GetDistanceFromOrigin(int[] point)
        {
            return Math.Sqrt(Math.Pow((point[0] - 0), 2) + Math.Pow((point[1] - 0), 2));
        }

        public override void Run()
        {
            int[][] input = new int[2][] { new int[] { 1, 3 }, new int[] { -2, 2 } };
            int K = 1;
            var result = KClosest(input, K);

            input = new int[3][] { new int[] { 3, 3 }, new int[] { 5, -1 }, new int[] { -2, 4 } };
            K = 2;
            result = KClosest(input, K);
        }
    }
}
