using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Note: Input string should contain unique charectersa
    /// </summary>
    [RelatedTopic(Topic.Array)]
    [RelatedTopic(Topic.Recursion)]
    public class StringPermutations : Question
    {
        public IList<string> GetStringPermutation(string s)
        {
            IList<string> result = new List<string>();
            PermutationRecursionHelper(ref result, s.ToCharArray(), new List<char>());
            return result;
        }

        private void PermutationRecursionHelper(ref IList<string> result, char[] input, List<char> charList)
        {
            if (input.Length == charList.Count)
            {
                result.Add(string.Join("", charList));
            }

            foreach (char c in input)
            {
                if (!charList.Contains(c))
                {
                    List<char> tempCharList = new List<char>(charList);
                    tempCharList.Add(c);
                    PermutationRecursionHelper(ref result, input, tempCharList);
                }
            }
        }

        public override void Run()
        {
            // Example 1
            string s = "ABC";
            var result = GetStringPermutation(s);

            // Example 2
            s = "IndraNil";
            result = GetStringPermutation(s);
        }
    }
}
