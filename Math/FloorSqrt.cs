using Algorithms.Contracts;
using System;

namespace Math
{
    public class FloorSqrt : Question
    {
        public int GetFloorSqrt(int n)
        {
            return 0;
        }

        public override void Run()
        {
            int n1 = 4;
            int n2 = 2147395600;

            Console.WriteLine($"Input: {n1}\nExpected: {2}\nOutput: {GetFloorSqrt(n1)}\n");
            Console.WriteLine($"Input: {n2}\nExpected: {46340}\nOutput: {GetFloorSqrt(n2)}\n");
        }
    }
}
