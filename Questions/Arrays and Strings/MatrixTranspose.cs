using Algorithms.Contracts;

namespace Arrays_and_Strings
{
    public class TransposeMatrix : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/transpose-matrix/
        /// Given a matrix A, return the transpose of A.
        /// The transpose of a matrix is the matrix flipped over it's main diagonal, switching the row and column indices of the matrix.
        /// Example 1:
        ///     Input: [[1,2,3],[4,5,6],[7,8,9]]
        ///     Output: [[1,4,7],[2,5,8],[3,6,9]]
        /// </summary>
        public int[,] Transpose(int[,] A)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            int[,] result = new int[c, r];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    result[j, i] = A[i, j];
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int[,] input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Transpose(input);

            // Example 2
            input = new int[,]
            {
                { 1, 2, 3, 9 },
                { 4, 5, 6, 9 },
                { 7, 8, 9, 9 }
            };
            Transpose(input);
        }
    }
}
