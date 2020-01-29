using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/power-of-four/
    /// Given an integer (signed 32 bits), write a function to check whether it is a power of 4.
    /// Example 1:
    ///     Input: 16
    ///     Output: true
    /// Example 2:
    ///     Input: 5
    ///     Output: false
    /// Follow up: Could you solve it without loops/recursion?
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.BitManipulation)]
    public class PowerofFour : Question
    {
        // Taking Log to the base 4 of the number
        public bool IsPowerOfFour(int num)
        {
            if (num <= 0)
                return false;

            var log4Val = System.Math.Log(num, 4);
            return log4Val == System.Math.Floor(log4Val);
        }

        public override void Run()
        {
            // Example 1
            // Output: true
            int num = 16;
            var result = IsPowerOfFour(num);

            // Example 2
            // Output: false
            num = 5;
            result = IsPowerOfFour(num);
        }
    }
}
