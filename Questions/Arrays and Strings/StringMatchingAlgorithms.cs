using Algorithms.Contracts;

namespace Arrays_and_Strings
{
    /// <summary>
    /// This class contains various string matching algorithms
    /// </summary>
    public class StringMatchingAlgorithms : Question
    {
        public int BruteForceStringMatch(string T, int n, string P, int m)
        {
            for (int i = 0; i <= n - m; i++)
            {
                int j = 0;
                while (j < m && T[i + j] == P[j])
                {
                    j++;
                }

                if (j == m)
                {
                    return i;
                }
            }

            return -1;
        }

        public override void Run()
        {
            // Example 1
            string T = "ABCDEF";
            string P = "AB";
            int result = BruteForceStringMatch(T, T.Length, P, P.Length);
        }
    }
}
