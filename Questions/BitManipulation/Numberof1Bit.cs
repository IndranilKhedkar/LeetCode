using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace BitManipulation
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/number-of-1-bits/
    /// Write a function that takes an unsigned integer and return the number of '1' bits it has (also known as the Hamming weight).
    /// Example 1:
    ///     Input: 00000000000000000000000000001011
    ///     Output: 3
    ///     Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.
    /// </summary>
    [RelatedTopic(Topic.BitManipulation)]
    public class Numberof1Bit : Question
    {
        public int HammingWeight(uint n)
        {
            int result = 0;

            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    result += 1;
                }
                n >>= 1;
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: 3
            uint n = 11;
            var result = HammingWeight(n);

            // Example 2
            // Output: 3
            n = 128;
            result = HammingWeight(n);

            // Example 3
            // Output: 31
            n = 4294967293;
            result = HammingWeight(n);
        }
    }
}
