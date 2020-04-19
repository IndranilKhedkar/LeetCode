using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: Given an array of strings, group anagrams together.
    /// Example:
    ///     Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    ///     Output:
    ///             [
    ///               ["ate","eat","tea"],
    ///               ["nat","tan"],
    ///               ["bat"]
    ///             ]
    /// Note:
    ///     All inputs will be in lowercase.
    ///     The order of your output does not matter.
    /// 
    /// </summary>
    public class GroupAnagrams : Question
    {
        public IList<IList<string>> GetGroupedAnagrams(string[] strs)
        {
            var result = strs
                .Select(s => { var ss = string.Concat(s.OrderBy(c => c)); return new { s, ss }; })
                .GroupBy(s => s.ss)
                .Select(s => s.SelectMany(x => new List<string> { x.s }).ToList()).ToList()
                .ToList();

            return result.Select(s => s).Cast<IList<string>>().ToList();
        }

        public override void Run()
        {
            // Example 1

            string[] arr = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var resul = GetGroupedAnagrams(arr);
        }
    }
}
