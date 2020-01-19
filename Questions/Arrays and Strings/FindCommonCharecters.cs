using Algorithms.Contracts;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    public class FindCommonCharecters : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/find-common-characters/
        /// Given an array A of strings made only from lowercase letters, return a list of all characters that show up in all strings within the list (including duplicates).  
        /// For example, if a character occurs 3 times in all strings but not 4 times, you need to include that character three times in the final answer.
        /// You may return the answer in any order.
        /// Example 1:
        ///     Input: ["bella","label","roller"]
        ///     Output: ["e","l","l"]
        /// 
        /// Example 2:
        ///     Input: ["cool","lock","cook"]
        ///     Output: ["c","o"]
        /// </summary>
        public IList<string> CommonChars(string[] A)
        {
            List<string> result = new List<string>();

            if (A.Length <= 1)
                return result;

            int[] masterCharCouner = GetLowerCaseCharCounter(A[0]);

            for (int i = 1; i < A.Length; i++)
            {
                int[] tempCharCounter = GetLowerCaseCharCounter(A[i]);

                for (int j = 0; j < masterCharCouner.Length; j++)
                {
                    masterCharCouner[j] = Math.Min(masterCharCouner[j], tempCharCounter[j]);
                }
            }

            for (int i = 0; i < masterCharCouner.Length; i++)
            {
                while (masterCharCouner[i] > 0)
                {
                    result.Add(((char)(i + 'a')).ToString());
                    masterCharCouner[i]--;
                }
            }

            return result;
        }

        private int[] GetLowerCaseCharCounter(string str)
        {
            int[] result = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                result[str[i] - 'a'] += 1;
            }
            return result;
        }

        public override void Run()
        {
            // Example 1
            string[] input = new string[] { "bella", "label", "roller" };
            var result = CommonChars(input);

            // Example 2
            input = new string[] { "cool", "lock", "cook" };
            result = CommonChars(input);
        }
    }
}
