using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Library.Sorting
{
    public class BucketSort
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;
            int[] result = new int[length];

            int numOfBuckets = 10;
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < length; i++)
            {
                int bucket = (arr[i] / numOfBuckets);
                buckets[bucket].Add(arr[i]);
            }

            int index = 0;
            for (int i = 0; i < numOfBuckets; i++)
            {
                if (buckets[i].Any())
                {
                    int[] sortedArray = new InsertionSort<int>().Sort(buckets[i].ToArray());
                    for (int j = 0; j < sortedArray.Length; j++)
                    {
                        result[index++] = sortedArray[j];
                    }
                }
            }

            return result;
        }
    }
}
