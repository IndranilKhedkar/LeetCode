using Algorithms.Contracts;
using System;

namespace Matrix
{
    public class GameOfLife : Question
    {
        public void GameOfLifeSolution(int[][] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            int[][] tempBoard = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                tempBoard[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    int liveNeighbours = GetTotalLiveNeighbours(board, rows, cols, i, j);
                    Console.WriteLine($"{i}, {j}, {liveNeighbours}");
                    if (board[i][j] == 1)
                    {
                        if (liveNeighbours < 2)
                        {
                            tempBoard[i][j] = 0;
                        }
                        else if (liveNeighbours == 2 || liveNeighbours == 3)
                        {
                            tempBoard[i][j] = 1;
                        }
                        else
                        {
                            tempBoard[i][j] = 0;
                        }
                    }
                    else if (liveNeighbours == 3)
                    {
                        tempBoard[i][j] = 1;
                    }
                    else
                    {
                        tempBoard[i][j] = board[i][j];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i][j] = tempBoard[i][j];
                }
            }
        }

        private int GetTotalLiveNeighbours(int[][] board, int rows, int cols, int row, int col)
        {
            int result = 0;
            if (row - 1 >= 0 && col - 1 >= 0 && board[row - 1][col - 1] == 1)
            {
                result++;
            }
            if (row - 1 >= 0 && board[row - 1][col] == 1)
            {
                result++;
            }
            if (row - 1 >= 0 && col + 1 < cols && board[row - 1][col + 1] == 1)
            {
                result++;
            }
            if (col + 1 < cols && board[row][col + 1] == 1)
            {
                result++;
            }
            if (col + 1 < cols && row + 1 < rows && board[row + 1][col + 1] == 1)
            {
                result++;
            }
            if (row + 1 < rows && board[row + 1][col] == 1)
            {
                result++;
            }
            if (col - 1 >= 0 && row + 1 < rows && board[row + 1][col - 1] == 1)
            {
                result++;
            }
            if (col - 1 >= 0 && board[row][col - 1] == 1)
            {
                result++;
            }

            return result;
        }

        public override void Run()
        {
            GameOfLifeSolution(
                new int[][]
                {
                    new int[]{ 0, 1, 0},
                    new int[]{0, 0, 1 },
                    new int[]{1, 1, 1 },
                    new int[]{0, 0, 0 }
                });
        }
    }
}
