using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/is-subsequence/ 
    /// Given a string s and a string t, check if s is subsequence of t.
    /// You may assume that there is only lower case English letters in both s and t.t is potentially a very long (length ~= 500,000) string, and s is a short string (<=100).
    /// A subsequence of a string is a new string which is formed from the original string by deleting some(can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, "ace" is a subsequence of "abcde" while "aec" is not).
    ///
    /// Example 1:
    ///     s = "abc", t = "ahbgdc"
    ///     Return true.
    ///
    /// Example 2:
    ///     s = "axc", t = "ahbgdc"
    ///     Return false. 
    /// </summary>
    public class IsSubsequenceProblem : Question
    {
        public bool IsSubsequence(string s, string t)
        {
            int sLen = s.Length;
            int tLen = t.Length;
            int sCounter = 0;

            for (int i = 0; i < tLen; i++)
            {
                if (sCounter == sLen)
                    break;

                if (s[sCounter] == t[i])
                {
                    sCounter++;
                }
            }

            return sCounter == sLen;
        }

        public override void Run()
        {
            // Example 1
            // Output: true
            string s = "abc";
            string t = "ahbgdc";
            var result = IsSubsequence(s, t);

            // Example 2
            // Output: false
            s = "axc";
            t = "ahbgdc";
            result = IsSubsequence(s, t);
        }
    }
}
