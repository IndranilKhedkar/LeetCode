using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Linq;

namespace Recursion
{
    /// <summary>
    /// Gerate all the strings of length n drawn from 0... k – 1.
    /// </summary>
    [RelatedTopic(Topic.Recursion)]
    public class KAryStrings : Question
    {
        readonly int[] A = new int[10];

        public void GenerateKAryString(int n, int k)
        {
            if (n < 1)
            {
                Console.WriteLine(string.Join(',', A).ToString());
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    A[n - 1] = i;
                    GenerateKAryString(n - 1, k);
                }
            }
        }

        public override void Run()
        {
            // Example 1
            GenerateKAryString(5, 5);
        }
    }
}
