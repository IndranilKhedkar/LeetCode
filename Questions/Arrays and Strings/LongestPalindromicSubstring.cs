using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/longest-palindromic-substring/
    /// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
    /// Example 1:
    ///     Input: "babad"
    ///     Output: "bab"
    ///     Note: "aba" is also a valid answer.
    /// 
    /// Example 2:
    ///     Input: "cbbd"
    ///     Output: "bb"
    /// </summary>
    [RelatedTopic(Topic.String)]
    [RelatedTopic(Topic.DynamicProgramming)]
    public class LongestPalindromicSubstring : Question
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            int length = s.Length;
            int maxPalindromicLength = 1;
            int left = 0, right = 0;
            char[] sCharArr = s.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j > i && maxPalindromicLength < (j - i + 1); j--)
                {
                    if (IsPalindrome(sCharArr, i, j))
                    {
                        left = i;
                        right = j;
                        maxPalindromicLength = Math.Max(maxPalindromicLength, (right - left + 1));
                    }
                }
            }

            return s.Substring(left, (right - left + 1));
        }

        private bool IsPalindrome(char[] s, int left, int right)
        {
            while (left < right)
            {
                if (s[left++] != s[right--])
                {
                    return false;
                }
            }
            return true;
        }

        public override void Run()
        {
            // Example 1
            string s = "babad";
            var result = LongestPalindrome(s);

            // Example 2
            s = "cbbd";
            result = LongestPalindrome(s);

            // Example 3
            s = "aaaaaaa";
            result = LongestPalindrome(s);
        }
    }
}
