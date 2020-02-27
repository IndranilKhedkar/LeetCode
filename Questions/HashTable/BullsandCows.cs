using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections;

namespace HashTable
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/bulls-and-cows/
    /// You are playing the following Bulls and Cows game with your friend: You write down a number and ask your friend to guess what the number is. Each time your friend makes a guess, you provide a hint that indicates how many digits in said guess match your secret number exactly in both digit and position (called "bulls") and how many digits match the secret number but locate in the wrong position (called "cows"). Your friend will use successive guesses and hints to eventually derive the secret number.
    /// Write a function to return a hint according to the secret number and friend's guess, use A to indicate the bulls and B to indicate the cows. 
    /// Please note that both secret number and friend's guess may contain duplicate digits.
    /// 
    /// Example 1:
    ///     Input: secret = "1807", guess = "7810"
    ///     Output: "1A3B"
    ///     Explanation: 1 bull and 3 cows.The bull is 8, the cows are 0, 1 and 7.
    /// Example 2:
    ///     Input: secret = "1123", guess = "0111"
    ///     Output: "1A1B"
    ///     Explanation: The 1st 1 in friend's guess is a bull, the 2nd or 3rd 1 is a cow.
    /// Note: You may assume that the secret number and your friend's guess only contain digits, and their lengths are always equal.
    /// </summary>
    [RelatedTopic(Topic.HashTable)]
    public class BullsandCows : Question
    {
        public string GetHint(string secret, string guess)
        {
            Hashtable secretHashtable = new Hashtable();
            Hashtable guessHashtable = new Hashtable();
            int A = 0;
            int B = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    A++;
                }
                else
                {
                    if (secretHashtable.ContainsKey(secret[i]))
                    {
                        secretHashtable[secret[i]] = (int)secretHashtable[secret[i]] + 1;
                    }
                    else
                    {
                        secretHashtable[secret[i]] = 1;
                    }

                    if (guessHashtable.ContainsKey(guess[i]))
                    {
                        guessHashtable[guess[i]] = (int)guessHashtable[guess[i]] + 1;
                    }
                    else
                    {
                        guessHashtable[guess[i]] = 1;
                    }
                }
            }

            foreach (DictionaryEntry entry in guessHashtable)
            {
                if (secretHashtable.ContainsKey(entry.Key))
                {
                    B += Math.Min((int)secretHashtable[entry.Key], (int)entry.Value);
                    secretHashtable.Remove(entry.Key);
                }
            }

            return $"{A}A{B}B";
        }

        public override void Run()
        {
            // Example 1
            string guess = "1807";
            string secret = "7810";
            var result = GetHint(guess, secret);

            // Example 2
            guess = "1123";
            secret = "0111";
            result = GetHint(guess, secret);

            // Example 3
            guess = "1122";
            secret = "2211";
            result = GetHint(guess, secret);
        }
    }
}
