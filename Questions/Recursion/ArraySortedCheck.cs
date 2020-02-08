using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Recursion
{
    /// <summary>
    /// Given an array, check whether the array is in sorted order with recursion.
    /// </summary>
    [RelatedTopic(Topic.Recursion)]
    public class ArraySortedCheck : Question
    {
        public bool IsArrayInAscendingSortedOrder(int[] arr, int index)
        {
            if (arr.Length == 1 || index == 1)
                return true;

            return (arr[index - 1] >= arr[index - 2]) && IsArrayInAscendingSortedOrder(arr, index - 1);
        }

        public bool IsArrayInDescendingSortedOrder(int[] arr, int index)
        {
            if (arr.Length == 1 || index == 1)
                return true;

            return (arr[index - 1] <= arr[index - 2]) && IsArrayInDescendingSortedOrder(arr, index - 1);
        }

        public override void Run()
        {
            // IsArrayInAscendingSortedOrder

            // Example 1
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            var result = IsArrayInAscendingSortedOrder(arr, arr.Length);

            // Example 2
            arr = new int[] { 5, 4, 3, 2, 1 };
            result = IsArrayInAscendingSortedOrder(arr, arr.Length);

            // Example 3
            arr = new int[] { 5, 5, 3, 3, 1, 1, 6, 6 };
            result = IsArrayInAscendingSortedOrder(arr, arr.Length);

            // IsArrayInDescendingSortedOrder

            // Example 1
            arr = new int[] { 1, 2, 3, 4, 5 };
            result = IsArrayInDescendingSortedOrder(arr, arr.Length);

            // Example 2
            arr = new int[] { 5, 4, 3, 2, 1 };
            result = IsArrayInDescendingSortedOrder(arr, arr.Length);

            // Example 3
            arr = new int[] { 5, 5, 3, 3, 1, 1, 6, 6 };
            result = IsArrayInDescendingSortedOrder(arr, arr.Length);
        }
    }
}
