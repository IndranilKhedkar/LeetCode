using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    public class ShortestDistanceToACharecter : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/shortest-distance-to-a-character/
        /// Given a string S and a character C, return an array of integers representing the shortest distance from the character C in the string.
        /// Example 1:
        ///     Input: S = "loveleetcode", C = 'e'
        ///     Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
        /// </summary>
        public int[] ShortestToChar(string S, char C)
        {
            int prevPosition = int.MaxValue;
            int len = S.Length;
            int i = 0;
            int[] result = new int[len];

            while (S[i] != C)
            {
                i++;
            }

            int nextPosition = i;

            for (i = 0; i < len; i++)
            {
                if (S[i] == C)
                {
                    nextPosition = i;
                    prevPosition = nextPosition;
                }

                result[i] = Math.Min(Math.Abs(nextPosition - i), Math.Abs(prevPosition - i));
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            string s = "loveleetcode";
            char c = 'e';
            var result = ShortestToChar(s, c);
        }
    }
}
