using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using LinkedList.Models;
using System;

namespace LinkedList
{
    /// <summary>
    /// Referenc Link: 
    /// </summary>
    [RelatedTopic(Topic.LinkedList)]
    public class ReverseLinkedList : Question
    {
        #region Interative Approach

        public ListNode ReverseListInterative(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode currNode = head.Next;
            ListNode prevNode = head;
            head.Next = null;

            while (currNode != null)
            {
                ListNode temp = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = temp;
            }

            return prevNode;
        }

        #endregion Interative Approach

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}