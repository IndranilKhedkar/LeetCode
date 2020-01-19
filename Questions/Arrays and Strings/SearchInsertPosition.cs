using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Helpers.TopicHelpers;
using Algorithms.Library.Extensions;
using System.Linq;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/search-insert-position/
    /// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    /// You may assume no duplicates in the array.
    /// Example 1:
    ///     Input: [1,3,5,6], 5
    ///     Output: 2
    /// Example 2:
    ///     Input: [1,3,5,6], 2
    ///     Output: 1
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.String)]
    public class SearchInsertPosition : Question
    {
        public int SearchInsert(int[] nums, int target)
        {
            int result = 0;
            int len = nums.Length;

            while (result < len && target > nums[result])
            {
                result++;
            }

            return result;
        }

        public int SearchInsert_BinarySearch(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return start;
        }

        public override void Run()
        {
            // Example 1
            // Output: 2
            int[] arr = new int[] { 1, 3, 5, 6 };
            int target = 5;
            var result = SearchInsert(arr, target);
            result = SearchInsert_BinarySearch(arr, target);

            // Example 2
            // Output: 1
            arr = new int[] { 1, 3, 5, 6 };
            target = 2;
            result = SearchInsert(arr, target);
            result = SearchInsert_BinarySearch(arr, target);

            // Example 3
            // Output: 4
            arr = new int[] { 1, 3, 5, 6 };
            target = 7;
            result = SearchInsert(arr, target);
            result = SearchInsert_BinarySearch(arr, target);

            // Example 4
            // Output: 0
            arr = new int[] { 1, 3, 5, 6 };
            target = 0;
            result = SearchInsert(arr, target);
            result = SearchInsert_BinarySearch(arr, target);

            // Example 5
            // Output: 1
            arr = new int[] { 1, 3 };
            target = 2;
            result = SearchInsert(arr, target);
            result = SearchInsert_BinarySearch(arr, target);
        }
    }
}
