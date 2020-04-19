using Algorithms.Contracts;
using System;
using System.Collections.Generic;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/array-partition-i/
    /// </summary>
    public class CountAndSay : Question
    {
        public string GetCountAndSay(int n)
        {
            return CountAndSayRecursiveHelper("1", 1, n);
        }

        public string CountAndSayRecursiveHelper(string result, int n, int target)
        {
            if (n == target)
            {
                return result;
            }

            int len = result.Length;
            string currentResult = "";

            for (int i = 0; i < len;)
            {
                int prevItem = result[i] - '0';
                int count = 1;
                int j = i + 1;

                while (j < len && prevItem == (result[j] - '0'))
                {
                    j++;
                    count++;
                }

                i = j;
                currentResult = $"{currentResult}{count.ToString()}{prevItem}";
            }

            return CountAndSayRecursiveHelper(currentResult, n + 1, target);
        }

        public override void Run()
        {
            // Example 1
            var result = GetCountAndSay(1);
            result = GetCountAndSay(2);
            result = GetCountAndSay(3);
            result = GetCountAndSay(4);
            result = GetCountAndSay(5);
        }
    }
}
