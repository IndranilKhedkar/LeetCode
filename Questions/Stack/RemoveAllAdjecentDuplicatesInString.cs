using Algorithms.Contracts;
using Algorithms.Helpers.TopicHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    /// Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.
    /// We repeatedly make duplicate removals on S until we no longer can.
    /// Return the final string after all such duplicate removals have been made.It is guaranteed the answer is unique.
    /// Example 1:
    ///     Input: "abbaca"
    ///     Output: "ca"
    ///     Explanation: For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
    /// </summary>
    public class RemoveAllAdjecentDuplicatesInString : Question
    {
        public string RemoveDuplicates(string S)
        {
            Stack<Char> stack = new Stack<char>();
            int len = S.Length;
            int i = 0;

            while (i < len)
            {
                if (stack.Count == 0 || stack.Peek() != S[i])
                {
                    stack.Push(S[i]);
                }
                else
                {
                    stack.Pop();
                }
                i++;
            }

            i = stack.Count;
            char[] result = new char[stack.Count];
            while (i > 0)
            {
                result[--i] = stack.Pop();
            }

            return new string(result);
        }

        public override void Run()
        {
            string input = "abbaca";
            var result = RemoveDuplicates(input);
        }
    }
}
