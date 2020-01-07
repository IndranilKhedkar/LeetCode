using Algorithms.Contracts;

namespace BitManipulation
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/hamming-distance/submissions/
    /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
    /// Given two integers x and y, calculate the Hamming distance.
    /// Note:
    ///     0 ≤ x, y< 231. 
    ///     
    /// Example 1:
    ///     Input : x = 1, y = 4
    ///     Output: 2
    ///     Explanation:
    ///     1   (0 0 0 1)
    ///     4   (0 1 0 0)
    ///            ↑   ↑
    ///     The above arrows point to positions where the corresponding bits are different.
    /// </summary>
    public class HammingDistance : Question
    {
        public int GetDistance(int x, int y)
        {
            int result = 0;
            int xor = x ^ y;

            while (xor != 0)
            {
                result += xor & 1;
                xor >>= 1;
            }

            return result;
        }

        public int GetDistance_1(int x, int y)
        {
            int result = 0;
            int xor = x ^ y;

            while (xor != 0)
            {
                result += (xor % 2);
                xor /= 2;
            }

            return result;
        }

        public override void Run()
        {
            GetDistance(1, 4);
            GetDistance(93, 73);
        }
    }
}
