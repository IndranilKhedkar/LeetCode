using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using LinkedList.Models;
using System;

namespace LinkedList
{
    /// <summary>
    /// Referenc Link: https://leetcode.com/problems/remove-linked-list-elements/
    /// Remove all elements from a linked list of integers that have value val.
    /// Example:
    ///     Input:  1->2->6->3->4->5->6, val = 6
    ///     Output: 1->2->3->4->5
    /// </summary>
    [RelatedTopic(Topic.LinkedList)]
    public class RemoveLinkedListElements : Question
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return head;

            while (head != null && head.Val == val)
            {
                ListNode tempNode = head;
                head = head.Next;
                tempNode = null;
            }

            ListNode currListNode = head?.Next;
            ListNode prevListNode = head;

            while (currListNode != null)
            {
                if (currListNode.Val == val)
                {
                    while (currListNode != null && currListNode.Val == val)
                    {
                        currListNode = currListNode.Next;
                    }
                    prevListNode.Next = currListNode;
                    //continue;
                }

                prevListNode = currListNode;
                currListNode = currListNode.Next;
            }

            return head;
        }

        public ListNode RemoveElements_1(ListNode head, int val)
        {
            if (head == null)
                return head;

            ListNode prevNode = null;
            ListNode result = head;

            while (head != null)
            {
                if (head.Val == val)
                {
                    if (prevNode != null)
                    {
                        prevNode.Next = head.Next;
                    }
                    else
                    {
                        result = result.Next;
                    }
                }
                else
                {
                    prevNode = head;
                }

                head = head.Next;
            }

            return result;
        }

        public ListNode RemoveElements2(ListNode head, int val)
        {
            if (head == null)
                return head;

            while (head != null && head.Val == val)
            {
                head = head.Next;
            }

            ListNode prevListNode = head;
            ListNode currListNode = head?.Next;

            while (currListNode != null)
            {
                if (currListNode.Val == val)
                {
                    prevListNode.Next = currListNode.Next;
                }
                else
                {
                    prevListNode = currListNode;
                }
                currListNode = currListNode.Next;
            }

            return head;
        }

        public override void Run()
        {
            ListNode listNode3 = new ListNode(1);

            ListNode listNode2 = new ListNode(2);
            listNode2.Next = listNode3;

            ListNode listNode1 = new ListNode(2);
            listNode1.Next = listNode2;

            ListNode head = new ListNode(1);
            head.Next = listNode1;

            var result = RemoveElements(head, 2);
        }
    }
}