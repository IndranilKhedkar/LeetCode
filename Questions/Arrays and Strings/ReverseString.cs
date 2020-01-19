using Algorithms.Contracts;

namespace Arrays_and_Strings
{
    public class ReverseString : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/reverse-string/
        /// Write a function that reverses a string. The input string is given as an array of characters char[].
        /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        /// You may assume all the characters consist of printable ascii characters.
        /// </summary>
        public string ReverseStringChars(char[] s)
        {
            int len = s.Length;
            char temp;

            for (int i = 0, j = len - 1; i < j; i++, j--)
            {
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            return new string(s);
        }

        public override void Run()
        {
            // Example 1
            char[] input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var result = ReverseStringChars(input);

            // Example 2
            input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            result = ReverseStringChars(input);
        }
    }
}
