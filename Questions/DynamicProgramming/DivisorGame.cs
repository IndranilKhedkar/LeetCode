using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace DynamicProgramming
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/divisor-game/
    /// Alice and Bob take turns playing a game, with Alice starting first.
    /// Initially, there is a number N on the chalkboard.On each player's turn, that player makes a move consisting of:
    ///     Choosing any x with 0 < x<N and N % x == 0.
    ///     Replacing the number N on the chalkboard with N - x.
    /// 
    /// Also, if a player cannot make a move, they lose the game.
    /// Return True if and only if Alice wins the game, assuming both players play optimally.
    /// Example 1:
    /// Input: 2
    /// Output: true
    /// Explanation: Alice chooses 1, and Bob has no more moves.
    /// 
    /// Example 2:
    /// Input: 3
    /// Output: false
    /// Explanation: Alice chooses 1, Bob chooses 1, and Alice has no more moves.
    /// Note: 1 <= N <= 1000
    /// </summary>
    [RelatedTopic(Topic.DynamicProgramming)]
    [RelatedTopic(Topic.Math)]
    public class DivisorGame : Question
    {
        public bool DivisorGameDP(int N)
        {
            return CanWin(N, new char[N]);
        }

        private bool CanWin(int n, char[] winMemory)
        {
            if (n <= 1)
                return false;

            if (winMemory[n] != default(char))
                return winMemory[n] == 'w';

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    if (!CanWin(n - i, winMemory))
                    {
                        winMemory[n] = 'w';
                        return true;
                    }
                }
            }

            winMemory[n] = 'l';
            return false;
        }

        public bool DivisorGameMath(int N)
        {
            return N % 2 == 0;
            //return !(N & 1);
        }


        public override void Run()
        {
            // Example 1
            // Output: true
            var result = DivisorGameDP(2);

            // Example 2
            // Output: false    
            result = DivisorGameDP(3);
        }
    }
}
