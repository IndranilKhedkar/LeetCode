using Algorithms.Contracts;

namespace BitManipulation
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/reverse-bits/
    /// Reverse bits of a given 32 bits unsigned integer.
    /// Example 1:
    /// Input: 00000010100101000001111010011100
    /// Output: 00111001011110000010100101000000
    /// Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.
    /// </summary>
    public class ReverseUIntBits : Question
    {
        public uint ReverseBits(uint n)
        {
            int index = 0;
            uint result = 0;

            while (index++ < 32)
            {
                uint t = n & 1;
                result <<= 1;
                result += t;
                n >>= 1;
            }

            return result;
        }


        public override void Run()
        {
            // Example 1
            // Output: 964176192 (00111001011110000010100101000000)
            uint n = 43261596; // (00000010100101000001111010011100)
            var result = ReverseBits(n);

            // Example 2
            // Output: 3221225471 (10111111111111111111111111111111)
            n = 4294967293; // (11111111111111111111111111111101)
            result = ReverseBits(n);
        }
    }
}
