using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/power-of-two/
    /// Given an integer, write a function to determine if it is a power of two.
    /// Example 1:
    ///     Input: 1
    ///     Output: true 
    ///     Explanation: 20 = 1
    /// Example 2:
    ///     Input: 16
    ///     Output: true
    ///     Explanation: 24 = 16
    /// Example 3:
    ///     Input: 218
    ///     Output: false
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.BitManipulation)]
    public class PowerofTwo : Question
    {
        // Taking mod of the heighest power of 2 val that 32-bit int can accomodate
        public bool IsPowerOfTwo(int num)
        {
            if (num <= 0)
                return false;

            return (1073741824 % num) == 0;
        }

        // Taking log to the base 3 of the number
        public bool IsPowerOfTwoLog2(int num)
        {
            if (num <= 0)
                return false;

            var log2Val = System.Math.Log(num, 2);
            return log2Val == System.Math.Floor(log2Val);
        }

        public override void Run()
        {
            // Example 1
            // Output: false
            int num = 1;
            var result = IsPowerOfTwo(num);

            // Example 2
            // Output: true
            num = 16;
            result = IsPowerOfTwo(num);

            // Example 3
            // Output: false    
            num = 218;
            result = IsPowerOfTwo(num);
        }
    }
}
