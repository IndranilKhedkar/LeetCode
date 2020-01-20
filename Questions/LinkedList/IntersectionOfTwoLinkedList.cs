using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using LinkedList.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    /// <summary>
    /// Referenc Link: https://leetcode.com/problems/intersection-of-two-linked-lists/
    /// Write a program to find the node at which the intersection of two singly linked lists begins.
    /// </summary>
    [RelatedTopic(Topic.LinkedList)]
    [RelatedTopic(Topic.HashSet)]
    public class IntersectionOfTwoLinkedList : Question
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode nodeA = headA;
            ListNode nodeB = headB;

            while (nodeA != nodeB)
            {
                nodeA = nodeA == null ? headB : nodeA.Next;
                nodeB = nodeB == null ? headA : nodeB.Next;
            }

            return nodeA;
        }

        public ListNode GetIntersectionNodeUsingHashTable(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> hashSet = new HashSet<ListNode>();

            while (headA != null)
            {
                hashSet.Add(headA);
                headA = headA.Next;
            }

            while (headB != null)
            {
                if (hashSet.Contains(headB))
                    return headB;

                headB = headB.Next;
            }

            return null;
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}