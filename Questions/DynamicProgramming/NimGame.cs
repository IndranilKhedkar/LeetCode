using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/nim-game/
    /// You are playing the following Nim Game with your friend: There is a heap of stones on the table, each time one of you take turns to remove 1 to 3 stones. The one who removes the last stone will be the winner. You will take the first turn to remove the stones.
    /// Both of you are very clever and have optimal strategies for the game.Write a function to determine whether you can win the game given the number of stones in the heap.
    /// Example:
    ///     Input: 4
    ///     Output: false 
    ///     Explanation: If there are 4 stones in the heap, then you will never win the game; No matter 1, 2, or 3 stones you remove, the last stone will always be removed by your friend.
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    public class NimGame : Question
    {
        public bool CanWinNim(int n)
        {
            Hashtable hashtable = new Hashtable
            {
                { 1, true },
                { 2, true },
                { 3, true },
                { 4, false }
            };

            for (int i = 5; i <= n; i++)
            {
                var result = !((bool)hashtable[i - 1] && (bool)hashtable[i - 2] && (bool)hashtable[i - 3]);
                hashtable.Add(i, result);
                hashtable.Remove(i - 4);
            }

            return (bool)hashtable[n];
        }

        // If value of n is multiple of 4, then the player can't win. 
        public bool CanWinNim_MathApproach(int n)
        {
            return !(n % 4 == 0);
        }

        public override void Run()
        {
            // Example 1
            var result = CanWinNim_MathApproach(4);
            //result = CanWinNim(1348820612);
        }

    }
}
