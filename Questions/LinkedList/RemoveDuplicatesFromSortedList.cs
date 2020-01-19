using Algorithms.Contracts;
using LinkedList.Models;

namespace Math
{
    /// <summary>
    /// Referenc Link: https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    /// Given a sorted linked list, delete all duplicates such that each element appear only once.
    /// Example 1:
    ///     Input: 1->1->2
    ///     Output: 1->2
    /// Example 2:
    ///     Input: 1->1->2->3->3
    ///     Output: 1->2->3
    /// </summary>
    public class RemoveDuplicatesFromSortedList : Question
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;

            ListNode prevNode = head;
            ListNode currNode = head.Next;

            while (currNode != null)
            {
                if (currNode.Val == prevNode.Val)
                {
                    prevNode.Next = currNode.Next;
                }
                else
                {
                    prevNode = currNode;
                }
                currNode = currNode.Next;
            }

            return head;
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}
