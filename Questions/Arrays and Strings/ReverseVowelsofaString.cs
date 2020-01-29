using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/reverse-vowels-of-a-string/
    /// Write a function that takes a string as input and reverse only the vowels of a string.
    /// Example 1:
    ///     Input: "hello"
    ///     Output: "holle"
    /// Example 2:
    ///     Input: "leetcode"
    ///     Output: "leotcede"
    /// Note: The vowels does not include the letter "y".
    /// </summary>
    [RelatedTopic(Topic.TwoPointers)]
    [RelatedTopic(Topic.Array)]
    public class ReverseVowelsofaString : Question
    {
        public string ReverseVowels(string s)
        {
            char[] result = new char[s.Length];
            int left = 0, right = s.Length - 1;
            HashSet<char> hashSet = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            while (left <= right)
            {
                if (hashSet.Contains(s[left]) && hashSet.Contains(s[right]))
                {
                    result[left] = s[right];
                    result[right] = s[left];

                    left++;
                    right--;

                    continue;
                }

                if (!hashSet.Contains(s[left]))
                {
                    result[left] = s[left++];
                }

                if (!hashSet.Contains(s[right]))
                {
                    result[right] = s[right--];
                }
            }

            return new string(result);
        }

        public override void Run()
        {
            // Example 1
            // Output: holle
            string str = "hello";
            var result = ReverseVowels(str);

            // Example 2
            // Output: leotcede
            str = "leetcode";
            result = ReverseVowels(str);

            // Example 3
            // Output: "   "
            str = "   ";
            result = ReverseVowels(str);

            // Example 4
            // Output: "."
            str = ".";
            result = ReverseVowels(str);
        }
    }
}
