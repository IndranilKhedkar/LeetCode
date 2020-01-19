using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using LinkedList.Models;
using System;

namespace LinkedList
{
    [RelatedTopic(Topic.LinkedList)]
    public class MiddleOfTheLinkedList : Question
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slowNode = head;
            ListNode fastNode = head;

            while (fastNode?.Next != null)
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }

            return slowNode.Next;
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}

