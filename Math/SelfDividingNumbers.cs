using Algorithms.Contracts;
using Algorithms.Library.Extensions;
using System.Collections.Generic;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/self-dividing-numbers/
    /// A self-dividing number is a number that is divisible by every digit it contains.
    /// For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
    /// Also, a self-dividing number is not allowed to contain the digit zero.
    /// Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible. 
    /// Example 1: 
    ///     Inputs: left = 1, right = 22
    ///     Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
    /// </summary>
    public class SelfDividingNumbers : Question
    {
        public IList<int> GetSelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();

            while (left <= right)
            {
                if (left.IsSelfDivisible())
                {
                    result.Add(left);
                }
                left++;
            }

            return result;
        }

        public override void Run()
        {
            GetSelfDividingNumbers(1, 22);
            GetSelfDividingNumbers(66, 708);
        }
    }
}
