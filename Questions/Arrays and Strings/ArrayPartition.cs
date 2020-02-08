using Algorithms.Contracts;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: 
    /// </summary>
    public class ArrayPartition : Question
    {
        public int[] PartitionArray(int[] nums, int k)
        {
            int l = 0;
            int m = 0;
            int r = nums.Length - 1;

            while (m < r)
            {
                if (nums[m] < k)
                {
                    Swap(ref nums, m, l);
                    m++;
                    l++;
                }
                else if (nums[m] > k)
                {
                    Swap(ref nums, r, m);
                    r--;
                }
                else
                {
                    m++;
                }
            }

            return nums;
        }

        private static void Swap(ref int[] nums, int p1, int p2)
        {
            int t = nums[p1];
            nums[p1] = nums[p2];
            nums[p2] = t;
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 1, 4, 3, 2 };
            int k = 3;
            var result = PartitionArray(arr, k);

            // Example 2
            arr = new int[] { 5, 4, 3, 2, 1 };
            k = 3;
            result = PartitionArray(arr, k);

            // Example 3
            arr = new int[] { 22, 1, 3, 5, 2, 4, 3, 2, 1, 4, 5, 9, 11 };
            k = 3;
            result = PartitionArray(arr, k);

            // Example 4
            arr = new int[] { 3, 22, 11, 1, 3, 5, 2, 4, 3, 2, 1, 4, 5, 9, 11 };
            k = 3;
            result = PartitionArray(arr, k);
        }
    }
}
