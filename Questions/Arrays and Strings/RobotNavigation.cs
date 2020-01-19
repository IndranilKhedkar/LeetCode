using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    public class RobotNavigation : Question
    {
        public bool JudgeCircle(string moves)
        {
            int len = moves.Length;
            int verticalMovement = 0;
            int horizontalMovement = 0;

            for (int i = 0; i < len; i++)
            {
                if (moves[i] == 'U')
                    verticalMovement++;
                else if (moves[i] == 'D')
                    verticalMovement--;
                else if (moves[i] == 'L')
                    horizontalMovement--;
                else if (moves[i] == 'R')
                    horizontalMovement++;
            }

            return verticalMovement == 0 && horizontalMovement == 0;
        }

        public override void Run()
        {
            // Example 1
            string moves = "UD";
            Console.WriteLine($"Input: {moves}\nExpected: true\nOutput: {JudgeCircle(moves).ToString()}\n");

            // Example 2
            moves = "LL";
            Console.WriteLine($"Input: {moves}\nExpected: false\nOutput: {JudgeCircle(moves).ToString()}\n");
        }
    }
}
