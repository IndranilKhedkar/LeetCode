using Algorithms.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class WordsThatCanBeFormedFromSetOfCharecters : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/
        /// </summary>
        public int CountCharacters(string[] words, string chars)
        {
            int result = 0;
            int wordsLength = words.Length;
            var charCounter = GetCharsCountMap(chars);

            for (int i = 0; i < wordsLength; i++)
            {
                Hashtable charCounterCopy = (Hashtable)charCounter.Clone();
                string word = words[i];
                int wordLength = word.Length;
                int j = 0;

                while (j < wordLength && charCounterCopy.Contains(word[j]) && ((int)charCounterCopy[word[j]]) > 0)
                {
                    charCounterCopy[word[j]] = (int)charCounterCopy[word[j]] - 1;
                    j++;
                }

                if (j == wordLength)
                    result += wordLength;
            }

            return result;
        }

        private Hashtable GetCharsCountMap(string chars)
        {
            Hashtable result = new Hashtable();
            for (int i = 0; i < chars.Length; i++)
            {
                if (result.ContainsKey(chars[i]))
                {
                    result[chars[i]] = (int)result[chars[i]] + 1;
                }
                else
                {
                    result.Add(chars[i], 1);
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            string[] words = new string[] { "cat", "bt", "hat", "tree" };
            string chars = "atach";
            int result = CountCharacters(words, chars);

            words = new string[] { "dyiclysmffuhibgfvapygkorkqllqlvokosagyelotobicwcmebnpznjbirzrzsrtzjxhsfpiwyfhzyonmuabtlwin", "ndqeyhhcquplmznwslewjzuyfgklssvkqxmqjpwhrshycmvrb", "ulrrbpspyudncdlbkxkrqpivfftrggemkpyjl", "boygirdlggnh", "xmqohbyqwagkjzpyawsydmdaattthmuvjbzwpyopyafphx", "nulvimegcsiwvhwuiyednoxpugfeimnnyeoczuzxgxbqjvegcxeqnjbwnbvowastqhojepisusvsidhqmszbrnynkyop", "hiefuovybkpgzygprmndrkyspoiyapdwkxebgsmodhzpx", "juldqdzeskpffaoqcyyxiqqowsalqumddcufhouhrskozhlmobiwzxnhdkidr", "lnnvsdcrvzfmrvurucrzlfyigcycffpiuoo", "oxgaskztzroxuntiwlfyufddl", "tfspedteabxatkaypitjfkhkkigdwdkctqbczcugripkgcyfezpuklfqfcsccboarbfbjfrkxp", "qnagrpfzlyrouolqquytwnwnsqnmuzphne", "eeilfdaookieawrrbvtnqfzcricvhpiv", "sisvsjzyrbdsjcwwygdnxcjhzhsxhpceqz", "yhouqhjevqxtecomahbwoptzlkyvjexhzcbccusbjjdgcfzlkoqwiwue", "hwxxighzvceaplsycajkhynkhzkwkouszwaiuzqcleyflqrxgjsvlegvupzqijbornbfwpefhxekgpuvgiyeudhncv", "cpwcjwgbcquirnsazumgjjcltitmeyfaudbnbqhflvecjsupjmgwfbjo", "teyygdmmyadppuopvqdodaczob", "qaeowuwqsqffvibrtxnjnzvzuuonrkwpysyxvkijemmpdmtnqxwekbpfzs", "qqxpxpmemkldghbmbyxpkwgkaykaerhmwwjonrhcsubchs" };
            chars = "usdruypficfbpfbivlrhutcgvyjenlxzeovdyjtgvvfdjzcmikjraspdfp";
            result = CountCharacters(words, chars);
        }
    }
}
