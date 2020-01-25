using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;

namespace Stack
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    /// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
    /// push(x) -- Push element x onto stack.
    /// pop() -- Removes the element on top of the stack.
    /// top() -- Get the top element.
    /// getMin() -- Retrieve the minimum element in the stack.
    /// </summary>
    [RelatedTopic(Topic.Stack)]
    public class MinStack : Question
    {
        ListNode stackTop;
        ListNode minStackTop;
        int currMin = int.MaxValue;

        public MinStack()
        { }

        public void Push(int x)
        {
            ListNode stackNode = new ListNode(x)
            {
                Next = stackTop
            };
            stackTop = stackNode;

            currMin = Math.Min(currMin, x);
            ListNode minStackNode = new ListNode(currMin)
            {
                Next = minStackTop
            };
            minStackTop = minStackNode;
        }

        public void Pop()
        {
            if (stackTop == null)
                throw new InvalidOperationException("Stack Underflow Exception!");

            ListNode topNode = stackTop;
            stackTop = stackTop.Next;
            topNode = null;

            ListNode minStackTopNode = minStackTop;
            minStackTop = minStackTopNode.Next;
            currMin = minStackTop?.Val ?? int.MaxValue;
            minStackTopNode = null;
        }

        public int Top()
        {
            if (stackTop == null)
                throw new InvalidOperationException("Empty Stack");

            return stackTop.Val;
        }

        public int GetMin()
        {
            if (minStackTop == null)
                throw new InvalidOperationException("Empty Stack");

            return minStackTop.Val;
        }

        private class ListNode
        {
            public int Val { get; }

            public ListNode Next { get; set; }

            public ListNode(int x) { Val = x; }
        }

        public override void Run()
        {
            // Example 1
            MinStack minStack1 = new MinStack();
            minStack1.Push(-2);
            minStack1.Push(0);
            minStack1.Push(-3);
            minStack1.GetMin();
            minStack1.Pop();
            minStack1.Top();
            minStack1.GetMin();

            // Example 2
            MinStack minStack2 = new MinStack();
            minStack2.Push(2147483646);
            minStack2.Push(2147483646);
            minStack2.Push(2147483647);
            minStack2.Top();
            minStack2.Pop();
            minStack2.GetMin();
            minStack2.Pop();
            minStack2.GetMin();
            minStack2.Pop();
            minStack2.Push(2147483647);
            minStack2.Top();
            minStack2.GetMin();
            minStack2.Push(-2147483648);
            minStack2.Top();
            minStack2.GetMin();
            minStack2.Pop();
            minStack2.GetMin();
        }
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
