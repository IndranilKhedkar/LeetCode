using Algorithms.Contracts;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    public class MaxDepthOfValidParanthesisStrings : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/maximum-nesting-depth-of-two-valid-parentheses-strings/
        /// </summary>
        /// <param name="seq"></param>
        /// <returns>MaxDepthAfterSplit</returns>
        public int[] MaxDepthAfterSplit(string seq)
        {
            int len = seq.Length;
            int[] result = new int[len];
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < len; i++)
            {
                char ch = seq[i];
                switch (ch)
                {
                    case '(':
                        result[i] = stack.Count % 2;
                        stack.Push(ch);
                        break;
                    case ')':
                        stack.Pop();
                        result[i] = stack.Count % 2;
                        break;
                }
            }

            return result;
        }

        public override void Run()
        {
            string seq1 = "(()())";
            string seq2 = "()(())()";

            Console.WriteLine($"Input: {seq1}\nExpected: {"[0,1,1,1,1,0]"}\nOutput: {MaxDepthAfterSplit(seq1)}\n");
            Console.WriteLine($"Input: {seq2}\nExpected: {"[0,0,0,1,1,0,1,1]"}\nOutput: {MaxDepthAfterSplit(seq2)}\n");
        }
    }
}
