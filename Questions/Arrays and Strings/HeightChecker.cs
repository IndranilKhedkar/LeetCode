using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    public class StudentsHeightChecker : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/height-checker/
        /// Students are asked to stand in non-decreasing order of heights for an annual photo.
        /// Return the minimum number of students not standing in the right positions.  
        /// (This is the number of students that must move in order for all students to be standing in non-decreasing order of height.)
        /// </summary>
        public int HeightChecker(int[] heights)
        {
            int len = heights.Length;
            int result = 0;
            int[] heightsCopy = new int[len];

            heights.CopyTo(heightsCopy, 0);

            Array.Sort(heightsCopy);

            for (int i = 0; i < len; i++)
            {
                if (heights[i] != heightsCopy[i])
                {
                    result += 1;
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[] input = new int[] { 1, 1, 4, 2, 1, 3 };
            HeightChecker(input);
        }
    }
}
