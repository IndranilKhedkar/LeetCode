using System;
using System.Collections.Generic;

namespace Algorithms.Library.Helpers
{
    public static class RationalMath
    {
        private static readonly Dictionary<int, double> FactorialMemory;

        static RationalMath()
        {
            FactorialMemory = new Dictionary<int, double>() { { 0, 1 }, { 1, 1 } };
        }

        public static long Combination(int n, int r)
        {
            return (long)Math.Round(Factorial(n) / (Factorial(r) * Factorial(n - r)));
        }

        public static long Permutation(int n, int r)
        {
            return (long)(Factorial(n) / Factorial(n - r));
        }

        public static double Factorial(int n)
        {
            if (FactorialMemory.ContainsKey(n))
                return FactorialMemory[n];

            if (n <= 1)
                return 1;

            for (int i = 2; i <= n; i++)
            {
                FactorialMemory[i] = FactorialMemory[i - 1] * i;
            }

            return FactorialMemory[n];

            //if (i <= 1)
            //    return 1;
            //FactorialMemory[i] = i * Factorial(i - 1);
            //return FactorialMemory[i];
        }

        public static HashSet<int> PrimeFactors(int n)
        {
            HashSet<int> result = new HashSet<int>();

            for (int i = 2; i <= n / i; i++)
            {
                while (n % i == 0)
                {
                    result.Add(i);
                    n /= i;
                }
            }

            if (n > 1)
            {
                result.Add(n);
            }

            return result;
        }
    }
}
