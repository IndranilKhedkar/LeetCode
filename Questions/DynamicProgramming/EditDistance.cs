using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/edit-distance/
    /// Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.
    /// You have the following 3 operations permitted on a word:
    ///     Insert a character
    ///     Delete a character
    ///     Replace a character
    /// 
    /// Example 1:
    ///     Input: word1 = "horse", word2 = "ros"
    ///     Output: 3
    ///     Explanation: 
    ///         horse -> rorse(replace 'h' with 'r')
    ///         rorse -> rose(remove 'r')
    ///         rose -> ros(remove 'e')
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    public class EditDistance : Question
    {
        public int MinDistance(string word1, string word2)
        {
            int word1Length = word1.Length;
            int word2Length = word2.Length;

            int[,] dp = new int[word1Length + 1, word2Length + 1];

            for (int i = 0; i <= word1Length; i++)
            {
                for (int j = 0; j <= word2Length; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = i;
                    }
                    else if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1]));
                    }
                }
            }

            return dp[word1Length, word2Length];
        }

        public override void Run()
        {
            // Example 1
            string word1 = "horse";
            string word2 = "ros";
            var result = MinDistance(word1, word2);

            new ArgumentNullException(nameof(result));

            // Example 2
            word1 = "intention";
            word2 = "execution";
            result = MinDistance(word1, word2);
        }
    }



    public interface IStringMap<TValue> where TValue : class
    {
        /// <summary>Returns number of elements in a map</summary>
        int Count { get; }

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        TValue DefaultValue { get; set; }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in the map, then the value associated with this key should be overridden.
        /// </summary>
        /// <returns>true if the value for the key was overridden, otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        bool AddElement(string key, TValue value);

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed, otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        bool RemoveElement(string key);

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        TValue GetValue(string key);
    }
















    // Do not change the name of this class
    public class StringMap<TValue> : IStringMap<TValue>
        where TValue : class
    {
        private readonly Dictionary<string, TValue> _stringMap;

        public StringMap()
        {
            _stringMap = new Dictionary<string, TValue>();
        }

        /// <summary> Returns number of elements in a map</summary>
        public int Count { get { return _stringMap.Count; } }

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        // Do not change this property
        public TValue DefaultValue { get; set; }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in a map, then the value associated with this key should be overriden.
        /// </summary>
        /// <returns>true if the value for the key was overriden otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        public bool AddElement(string key, TValue value)
        {
            ValidateKey(key);
            ValidateValue(value);

            if (_stringMap.ContainsKey(key))
            {
                _stringMap[key] = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        public bool RemoveElement(string key)
        {
            ValidateKey(key);

            return _stringMap.Remove(key);
        }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If a key is null</exception>
        /// <exception cref="System.ArgumentException">If a key is an empty string</exception>
        public TValue GetValue(string key)
        {
            ValidateKey(key);

            if (_stringMap.ContainsKey(key))
            {
                return _stringMap[key];
            }
            else
            {
                return DefaultValue;
            }
        }

        private void ValidateKey(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (key == string.Empty)
            {
                throw new ArgumentException("Key is empty", nameof(key));
            }
        }

        private void ValidateValue(TValue value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }

    public static class Validations
    {
        public static void NotNull(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
        }

        public static void StringNotEmpty(string s)
        {
            if (s == string.Empty)
            {
                throw new ArgumentException();
            }
        }
    }
}
