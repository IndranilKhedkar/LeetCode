using Algorithms.Contracts;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/fibonacci-number/
    /// The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
    /// F(0) = 0,   F(1) = 1
    /// F(N) = F(N - 1) + F(N - 2), for N > 1.
    /// Given N, calculate F(N).
    /// </summary>
    public class FibonacciNumber : Question
    {
        /// <summary>
        /// Dynamic Programming - By storing results
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Fib(int N)
        {
            int[] fibResult = new int[N + 1];
            return Fibonnaci(N, fibResult);
        }

        private int Fibonnaci(int n, int[] fibResult)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            if (fibResult[n] > 0)
            {
                return fibResult[n];
            }

            fibResult[n] = Fibonnaci(n - 1, fibResult) + Fibonnaci(n - 2, fibResult);

            return fibResult[n];
        }


        /// <summary>
        /// Recursive Approach
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Fib_1(int N)
        {
            if (N == 0 || N == 1)
                return N;

            return Fib_1(N - 1) + Fib_1(N - 2);
        }

        public override void Run()
        {
            int input = 4;
            int result = Fib(input);
        }
    }
}
