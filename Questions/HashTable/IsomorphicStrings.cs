using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections;

namespace HashTable
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/isomorphic-strings/
    /// Given two strings s and t, determine if they are isomorphic.
    /// Two strings are isomorphic if the characters in s can be replaced to get t.
    /// All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character but a character may map to itself.
    /// Example 1:
    ///     Input: s = "egg", t = "add"
    ///     Output: true
    /// Example 2:
    ///     Input: s = "foo", t = "bar"
    ///     Output: false
    /// Example 3:
    ///     Input: s = "paper", t = "title"
    ///     Output: true
    /// </summary>
    [RelatedTopic(Topic.HashTable)]
    public class IsomorphicStrings : Question
    {
        public bool IsIsomorphic(string s, string t)
        {
            Hashtable sHashTable = new Hashtable();
            Hashtable tHashTable = new Hashtable();

            for (int i = 0; i < s.Length; i++)
            {
                if (!sHashTable.ContainsKey(s[i]))
                {
                    sHashTable.Add(s[i], t[i]);
                }
                if (!tHashTable.ContainsKey(t[i]))
                {
                    tHashTable.Add(t[i], s[i]);
                }
                if ((char)sHashTable[s[i]] != t[i] || (char)tHashTable[t[i]] != s[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override void Run()
        {
            // Example 1
            string s = "egg";
            string t = "add";
            var result = IsIsomorphic(s, t);

            // Example 2
            s = "foo";
            t = "bar";
            result = IsIsomorphic(s, t);

            // Example 3
            s = "paper";
            t = "title";
            result = IsIsomorphic(s, t);

            // Example 4
            s = "ab";
            t = "aa";
            result = IsIsomorphic(s, t);
        }
    }
}
