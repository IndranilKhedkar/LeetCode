using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using LinkedList.Models;
using System;

namespace LinkedList
{
    /// <summary>
    /// Referenc Link: https://leetcode.com/problems/linked-list-cycle/
    /// Given a linked list, determine if it has a cycle in it.
    /// To represent a cycle in the given linked list, we use an integer pos which represents the position(0-indexed) in the linked list where tail connects to.If pos is -1, then there is no cycle in the linked list.
    /// </summary>
    [RelatedTopic(Topic.LinkedList)]
    public class LinkedListCycle : Question
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slowNode = head;
            ListNode fastNode = head?.Next;

            while (fastNode != null)
            {
                if (slowNode == fastNode)
                {
                    return true;
                }

                slowNode = slowNode.Next;
                fastNode = fastNode.Next?.Next;
            }

            return false;
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}