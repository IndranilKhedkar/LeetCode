using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/flipping-an-image/
    /// Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.
    /// To flip an image horizontally means that each row of the image is reversed.For example, flipping[1, 1, 0] horizontally results in [0, 1, 1].
    /// To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. For example, inverting[0, 1, 1] results in [1, 0, 0].
    /// Example 1:
    ///     Input: [[1,1,0],[1,0,1],[0,0,0]]
    ///     Output: [[1,0,0],[0,1,0],[1,1,1]]
    ///     Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
    ///     Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]
    /// Example 2:
    ///     Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
    ///     Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
    ///     Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
    ///     Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
    /// Constraints: 
    ///     1 <= A.length = A[0].length <= 20
    ///     0 <= A[i][j] <= 1
    /// </summary>
    public class FlippingImage : Question
    {
        public int[,] FlipAndInvertImage(int[,] A)
        {
            return new int[,] { };
        }

        public override void Run()
        {
            string address1 = "1.1.1.1";
            Console.WriteLine($"Input: {address1}\nExpected: {"1[.]1[.]1[.]1"}\nOutput:");

            string address2 = "255.100.50.0";
            Console.WriteLine($"Input: {address2}\nExpected: {"255[.]100[.]50[.]0"}\nOutput:");
        }
    }
}
