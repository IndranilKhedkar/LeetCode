using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/power-of-three/
    /// Given an integer, write a function to determine if it is a power of three.
    /// Example 1:
    ///     Input: 27
    ///     Output: true
    /// Example 2:
    ///     Input: 0
    ///     Output: false
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.BitManipulation)]
    public class PowerofThree : Question
    {
        // Taking mod of the heighest power of 3 val that 32-bit int can accomodate
        public bool IsPowerOfThree(int num)
        {
            if (num <= 0)
                return false;

            return (1162261467 % num) == 0;
        }

        // Taking log to the base 3 of the number
        public bool IsPowerOfThreeLog3(int num)
        {
            if (num <= 0)
                return false;

            var log3Val = System.Math.Log(num, 3);
            return log3Val == System.Math.Floor(log3Val);
        }

        public override void Run()
        {
            // Example 1
            // Output: true
            int num = 27;
            var result = IsPowerOfThree(num);

            // Example 2
            // Output: false
            num = 0;
            result = IsPowerOfThree(num);

            // Example 3
            // Output: true
            num = 9;
            result = IsPowerOfThree(num);
        }
    }
}
