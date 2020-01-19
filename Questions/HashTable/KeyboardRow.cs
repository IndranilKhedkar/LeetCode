using Algorithms.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/keyboard-row/
    /// Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
    /// </summary>
    public class KeyboardRow : Question
    {
        public string[] FindWords(string[] words)
        {
            int len = words.Length;
            List<string> result = new List<string>();
            Hashtable hashtable = new Hashtable()
            {
                { 'Q', 1}, { 'W', 1}, { 'E', 1}, { 'R', 1},{ 'T', 1}, { 'Y', 1}, { 'U', 1}, { 'I', 1}, { 'O', 1}, { 'P', 1},
                { 'A', 2}, { 'S', 2}, { 'D', 2}, { 'F', 2},{ 'G', 2}, { 'H', 2}, { 'J', 2}, { 'K', 2}, { 'L', 2},
                { 'Z', 3}, { 'X', 3}, { 'C', 3}, { 'V', 3},{ 'B', 3}, { 'N', 3}, { 'M', 3}
            };

            for (int i = 0; i < len; i++)
            {
                string word = words[i].ToUpper();
                int wordLength = word.Length;
                int prevIndex = 0;
                int j;

                for (j = 0; j < wordLength; j++)
                {
                    int currIndex = (int)hashtable[word[j]];
                    if (j != 0 && currIndex != prevIndex)
                    {
                        break;
                    }

                    prevIndex = currIndex;
                }

                if (j == wordLength)
                    result.Add(words[i]);
            }

            return result.ToArray();
        }


        public override void Run()
        {
            FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        }
    }
}
