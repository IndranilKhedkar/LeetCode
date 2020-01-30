using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/add-digits/
    /// Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
    /// Example:
    ///     Input: 38
    ///     Output: 2 
    /// Explanation: The process is like: 3 + 8 = 11, 1 + 1 = 2. 
    ///              Since 2 has only one digit, return it.
    /// Follow up: Could you do it without any loop/recursion in O(1) runtime?
    /// </summary>
    [RelatedTopic(Topic.Math)]
    public class AddNumberDigits : Question
    {
        public int AddDigits(int num)
        {
            if (num == 0)
                return 0;

            var numMod9 = (num % 9);
            return (numMod9 == 0) ? 9 : numMod9;
        }

        public override void Run()
        {
            // Example 1
            // Output: 2
            int input = 38;
            var result = AddDigits(input);

            // Example 2
            // Output: 2
            input = 11;
            result = AddDigits(input);

            // Example 3
            // Output: 1
            input = 10000;
            result = AddDigits(input);
        }
    }
}
