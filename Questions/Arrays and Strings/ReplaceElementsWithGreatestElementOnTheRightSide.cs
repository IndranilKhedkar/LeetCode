using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    /// Given an array arr, replace every element in that array with the greatest element among the elements to its right, 
    /// and replace the last element with -1.After doing so, return the array.
    /// </summary>
    public class ReplaceElementsWithGreatestElementOnTheRightSide : Question
    {
        public int[] ReplaceElements(int[] arr)
        {
            int len = arr.Length;
            int currentMax = arr[len - 1];

            for (int i = len - 1; i >= 0; i--)
            {
                if (i == len - 1)
                {
                    arr[len - 1] = -1;
                }
                else
                {
                    int temp = arr[i];
                    arr[i] = currentMax;

                    if (temp > currentMax)
                    {
                        currentMax = temp;
                    }
                }
            }

            return arr;
        }

        public override void Run()
        {
            // Example 1
            int[] arr = new int[] { 17, 18, 5, 4, 6, 1 };

            var result = ReplaceElements(arr);

            Console.WriteLine($"Expected Output: [18,6,6,6,1,-1]\nActual Output: ");
            Console.Write(string.Join(", ", result));
            Console.WriteLine();
        }
    }
}

