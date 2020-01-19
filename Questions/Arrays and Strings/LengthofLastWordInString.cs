using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/length-of-last-word/
    /// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word (last word means the last appearing word if we loop from left to right) in the string.
    /// If the last word does not exist, return 0.
    /// Note: A word is defined as a maximal substring consisting of non-space characters only.
    /// Example:
    ///     Input: "Hello World"
    ///     Output: 5
    /// </summary>
    [RelatedTopic(Topic.String)]
    public class LengthofLastWordInString : Question
    {
        public int LengthofLastWord(string s)
        {
            int len = s.Length;
            int i = len - 1;
            int result = 0;

            // Remove trailing spaces
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            // Length of the last word
            while (i >= 0 && s[i] != ' ')
            {
                result++;
                i--;
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: 5
            string s = "Hello World";
            var result = LengthofLastWord(s);

            // Example 2
            // Output: 1
            s = "a";
            result = LengthofLastWord(s);

            // Example 3
            // Output: 0
            s = "   ";
            result = LengthofLastWord(s);

            // Example 4
            // Output: 3
            s = " abc def ";
            result = LengthofLastWord(s);

            // Example 5
            // Output: 3
            s = "abc ";
            result = LengthofLastWord(s);

            // Example 6
            // Output: 3
            s = "   abc";
            result = LengthofLastWord(s);
        }
    }
}
