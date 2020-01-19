using Algorithms.Contracts;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    public class OccurancesAfterBigrams : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/occurrences-after-bigram/
        /// Given words first and second, consider occurrences in some text of the form "first second third", 
        /// where second comes immediately after first, and third comes immediately after second.
        /// For each such occurrence, add "third" to the answer, and return the answer.
        /// Example 1:
        ///     Input: text = "alice is a good girl she is a good student", first = "a", second = "good"
        ///     Output: ["girl","student"]
        /// </summary>
        public string[] FindOcurrences(string text, string first, string second)
        {
            string[] strings = text.Split(' ');
            int len = strings.Length;
            List<string> result = new List<string>();

            for (int i = 1; i < len; i++)
            {
                if (strings[i] == second && strings[i - 1] == first && i + 1 < len)
                    result.Add(strings[i + 1]);
            }

            return result.ToArray();
        }

        public override void Run()
        {
            // Example 1
            string text = "alice is a good girl she is a good student";
            string first = "a";
            string second = "good";
            string[] result = FindOcurrences(text, first, second);

            // Example 2
            text = "we will we will rock you";
            first = "we";
            second = "will";
            result = FindOcurrences(text, first, second);
        }
    }
}
