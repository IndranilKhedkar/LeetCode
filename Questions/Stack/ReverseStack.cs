using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    [RelatedTopic(Topic.Stack)]
    public class ReverseStack : Question
    {
        private static readonly Stack<int> stack = new Stack<int>();

        private void Reverse()
        {
            if (stack.Count > 0)
            {
                int x = stack.Pop();
                Reverse();
                InsertAtBotton(x);
            }
        }

        private void InsertAtBotton(int x)
        {
            if (stack.Count == 0)
            {
                stack.Push(x);
            }
            else
            {
                int a = stack.Pop();
                InsertAtBotton(x);
                stack.Push(a);
            }
        }

        private void PrintStack()
        {
            StringBuilder stringBuilder = new StringBuilder("[");
            foreach (int i in stack)
            {
                stringBuilder.Append($"{i}, ");
            }
            Console.WriteLine(stringBuilder.Append("]").ToString());
        }

        public override void Run()
        {
            for (int i = 9; i >= 0; i--)
            {
                stack.Push(i);
            }

            Console.WriteLine("Original Stack");
            PrintStack();

            Reverse();

            Console.WriteLine("Reversed Stack");
            PrintStack();
        }
    }
}
