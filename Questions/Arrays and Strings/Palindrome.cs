using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/valid-palindrome/
    /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    /// Note: For the purpose of this problem, we define empty string as valid palindrome.
    /// Example 1:
    ///     Input: "A man, a plan, a canal: Panama"
    ///     Output: true
    /// Example 2:
    ///     Input: "race a car"
    ///     Output: false
    /// </summary>
    [RelatedTopic(Topic.Array)]
    public class Palindrome : Question
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int len = s.Length;

            for (int i = 0, j = len - 1; i < j;)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                else if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }
                else if (s[i] != s[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }

            return true;
        }

        public override void Run()
        {
            // Example 1
            string input = "A man, a plan, a canal: Panama";
            var result = IsPalindrome(input);

            // Example 2
            input = "race a car";
            result = IsPalindrome(input);
        }
    }
}
