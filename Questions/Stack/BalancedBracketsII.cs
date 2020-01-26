using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System.Collections.Generic;

namespace Stack
{
    [RelatedTopic(Topic.Stack)]
    public class BalancedBracketsII : Question
    {
        public int Solve(string s)
        {
            Stack<char> stack = new Stack<char>();
            int len = s.Length;
            int result = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case '{':
                        if (stack.Count == 0)
                        {
                            result += 2;
                        }
                        else if (stack.Count == 1)
                        {
                            stack.Pop();
                            result += 1;
                        }
                        else
                        {
                            stack.Pop();
                            stack.Pop();
                        }

                        if (stack.Count % 2 != 0)
                        {
                            stack.Pop();
                            result += 2;
                        }

                        break;
                    case '}':
                        stack.Push('}');
                        break;
                }
            }

            result += stack.Count % 2 == 0 ? stack.Count / 2 : (stack.Count / 2) + 2;

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: 0
            string input = "{}}";
            var result = Solve(input);

            // Example 2
            // Output: 3
            input = "{}{}}}";
            result = Solve(input);

            // Example 3
            // Output: 0
            input = "";
            result = Solve(input);

            // Example 4
            // Output: 2
            input = "{";
            result = Solve(input);

            // Example 5
            // Output: 2
            input = "}";
            result = Solve(input);

            // Example 6
            // Output: 2
            input = "}}{}{}";
            result = Solve(input);

            // Example 7
            // Output: 2
            input = "{{{{{";
            result = Solve(input);
        }
    }
}
