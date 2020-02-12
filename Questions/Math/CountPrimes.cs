using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Extensions;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/count-primes/
    /// Count the number of prime numbers less than a non-negative number, n.
    /// Example:
    ///     Input: 10
    ///     Output: 4
    ///     Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
    /// </summary>
    [RelatedTopic(Topic.Math)]
    public class CountPrimesNumbers : Question
    {
        public int CountPrimes(int n)
        {
            int result = 0;

            if ((n - 1) <= 1)
                return result;

            for (int i = 2; i < n; i++)
            {
                if (i.IsPrime())
                {
                    result += 1;
                }
            }

            return result;
        }

        public override void Run()
        {
            var result = CountPrimes(10);
            result = CountPrimes(20);
            result = CountPrimes(100);
        }
    }
}
