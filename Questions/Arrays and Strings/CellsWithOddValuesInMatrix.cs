using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/
    /// Given n and m which are the dimensions of a matrix initialized by zeros and given an array indices where indices[i] = [ri, ci]. 
    /// For each pair of [ri, ci] you have to increment all cells in row ri and column ci by 1.
    /// Return the number of cells with odd values in the matrix after applying the increment to all indices.
    /// </summary>
    public class CellsWithOddValuesInMatrix : Question
    {
        public int OddCells(int n, int m, int[,] indices)
        {
            int result = 0;
            int[,] matrix = new int[n, m];

            for (int i = 0; i < indices.GetLength(0); i++)
            {
                int row = indices[i, 0];
                int col = indices[i, 1];

                // Row
                for (int j = 0; j < m; j++)
                {
                    matrix[row, j] += 1;
                    result = matrix[row, j] % 2 != 0 ? result + 1 : result - 1;
                }

                // Column
                for (int k = 0; k < n; k++)
                {
                    matrix[k, col] += 1;
                    result = matrix[k, col] % 2 != 0 ? result + 1 : result - 1;
                }
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            int n = 2, m = 3;
            int[,] indices = new int[,] { { 0, 1 }, { 1, 1 } };
            Console.WriteLine($"Expected Output: 6\nActual Output: {OddCells(n, m, indices)}\n");

            // Example 2
            n = 2;
            m = 2;
            indices = new int[,] { { 1, 1 }, { 0, 0 } };
            Console.WriteLine($"Expected Output: 0\nActual Output: {OddCells(n, m, indices)}\n");

            // Example 3
            n = 48;
            m = 37;
            indices = new int[,] { { 40, 5 } };
            Console.WriteLine($"Expected Output: 83\nActual Output: {OddCells(n, m, indices)}\n");
        }
    }
}
