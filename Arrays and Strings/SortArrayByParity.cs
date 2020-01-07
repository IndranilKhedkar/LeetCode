using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/sort-array-by-parity/
    /// Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.
    /// You may return any answer array that satisfies this condition.
    /// Example 1:
    ///     Input: [3,1,2,4]
    ///     Output: [2,4,3,1]
    ///     The outputs[4, 2, 3, 1], [2, 4, 1, 3], and[4, 2, 1, 3] would also be accepted.
    /// Constraints: 
    ///     1 <= A.length = A[0].length <= 20
    ///     0 <= A[i][j] <= 1
    /// </summary>
    public class SortArrayByParity : Question
    {
        public int[] SortArray(int[] arr)
        {
            int len = arr.Length;
            int evenNoPointer = 0;
            int temp;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (evenNoPointer != i)
                    {
                        temp = arr[i];
                        arr[i] = arr[evenNoPointer];
                        arr[evenNoPointer] = temp;
                    }
                    evenNoPointer++;
                }
            }

            return arr;
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 3, 1, 2, 4 };
            int[] result = SortArray(arr);
            Console.WriteLine($"Input: [3, 1, 2, 4]\nExpected: [2,4,3,1]\nActual Output: ");
            Console.Write(string.Join(", ", result));
            Console.WriteLine();

            //Example 2
            arr = new int[] { 1, 0, 3 };
            result = SortArray(arr);
            Console.WriteLine($"Input: [1, 0, 3]\nExpected: [0, 1, 3]\nActual Output: ");
            Console.Write(string.Join(", ", result));
            Console.WriteLine();

            //Example 2
            arr = new int[] { 0, 1, 2 };
            result = SortArray(arr);
            Console.WriteLine($"Input: [0, 1, 2]\nExpected: [0, 2, 1]\nActual Output: ");
            Console.Write(string.Join(", ", result));
            Console.WriteLine();
        }
    }
}
